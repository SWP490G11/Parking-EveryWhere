﻿using AutoMapper;
using Back_end.Common;
using Back_end.Entities;
using Back_end.Helper;
using Back_end.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Back_end.Respository
{
    public interface IRequestRepository
    {
        Task AddAsync(RequestModel model, User requestBy);
        Task DeleteAsync(string idString);
        Task<ICollection<Request>> GetAllAsync();
        Task<Request> GetAsync(string idString);
        ICollection<Request> PaginateAsync(ICollection<Request> source, int pageNo, int pageSize);
        ICollection<Request> SortAsync(DirectionOfSort direction, string factor);
        Task UpdateAsync(string idString, UpdateRequestModel updateModel);

        Task CancelRequestAsync(string idString);

        Task AproveRequest(string idString);

        Task<ICollection<Request>> GetRequestToParking(string parkingID);
         Task<ICollection<Request>> GetRequestPendingToParkingNumer(string parkingID);
    }

    public class RequestRepository : IRequestRepository
    {

        private readonly ParkingDbContext _dbContext;
        private readonly ILogger<SlotRepository> _logger;
        private readonly IMapper _mapper;

        public RequestRepository(ParkingDbContext dbContext, ILogger<SlotRepository> logger, IMapper mapper)
        {
            _dbContext = dbContext;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task AddAsync(RequestModel model, User requestBy)
        {

            if (string.IsNullOrEmpty(model.ParkingID)) throw new ArgumentNullException();
            var parking = await _dbContext.Parkings.FirstAsync(c => c.ID.ToString().ToUpper().Trim().
                Equals(model.ParkingID.ToUpper().Trim()
                ));

            if (parking.Requests == null) parking.Requests =new List<Request>();

            var request = new Request()
            {
                LastModifyAt = DateTime.Now,
                Note = model.Note,
                Requestby=requestBy,
                Parking= parking,
                RequestAt= DateTime.Now,
                Status  = Status.Pending,
            } ; 

            
             parking.Requests.Add(request);
             _dbContext.Requests.Add(request);

             _dbContext.SaveChanges();

        }

        public async Task CancelRequestAsync(string idString)
        {
            var updateRequest = await GetAsync(idString);
            updateRequest.Status = Status.Cancel;

            _dbContext.Update(updateRequest);
             _dbContext.SaveChanges();
        }

        public async Task DeleteAsync(string idString)
        {
            var request = await GetAsync(idString);
            _dbContext.Remove(request);

           await _dbContext.SaveChangesAsync();

        }

        public async Task<ICollection<Request>> GetAllAsync()
        {
           return  await _dbContext.Requests.Include(r => r.Requestby).ThenInclude(rb => rb.Image).Include(r => r.Parking).ToListAsync();
        }

        public async Task<Request> GetAsync(string idString)
        {
            if (string.IsNullOrEmpty(idString)) throw new ArgumentNullException();
            return await _dbContext.Requests.Include(r => r.Requestby).ThenInclude(rb => rb.Image).Include(r=>r.Parking).FirstAsync(c => c.ID.ToString().ToUpper().Trim().
                Equals(idString.ToUpper().Trim()
                ));
        }

        public async Task<ICollection<Request>> GetRequestToParking(string parkingID)
        {
            var requests = await _dbContext.Requests.Include(x=>x.Requestby).ThenInclude(rb=>rb.Image).Include(r => r.Parking).Where(x=>x.Parking.ID.ToString().Trim().ToLower()          
            .Equals(parkingID.Trim().ToLower())).ToListAsync();
            return requests;
        }


        public async Task<ICollection<Request>> GetRequestPendingToParking(string parkingID)
        {
            var requests = await _dbContext.Requests.Include(x => x.Requestby).ThenInclude(rb => rb.Image).Include(r => r.Parking).ToListAsync();
            return requests;
        }
         public async Task<ICollection<Request>> GetRequestPendingToParkingNumer(string parkingID)
        {
            var requests = await _dbContext.Requests.Include(x=>x.Requestby).ThenInclude(rb => rb.Image).Include(r => r.Parking).Where(x=>x.Parking.ID.ToString().Trim().ToLower()          
            .Equals(parkingID.Trim().ToLower())).Where(p=>p.Status == Status.Pending).ToListAsync();
            return requests;
        }
        public ICollection<Request> PaginateAsync(ICollection<Request> source, int pageNo, int pageSize)
        {
            throw new NotImplementedException();
        }

        public ICollection<Request> SortAsync(DirectionOfSort direction, string factor)
        {
            throw new NotImplementedException();
        }



        public async Task UpdateAsync(string idString, UpdateRequestModel updateModel)
        {
            var updateRequest =  await GetAsync(idString);
            updateRequest.Note = updateModel.Note;
            updateRequest.Status = updateModel.Status;
            updateRequest.LastModifyAt = DateTime.Now;

            _dbContext.Requests.Update(updateRequest);
             _dbContext.SaveChanges();
        }

        public async Task AproveRequest(string idString)
        {
            var updateRequest = await GetAsync(idString);
            updateRequest.Status = Status.Done;

            _dbContext.Update(updateRequest);
            _dbContext.SaveChanges();
        }

      
    }

}
