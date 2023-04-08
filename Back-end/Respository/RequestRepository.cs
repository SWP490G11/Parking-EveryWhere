using AutoMapper;
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

        Task CancelRequest(string idString);

        Task<ICollection<Request>> GetRequestToParking(string parkingID);
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

            var request = new Request()
            {
                LastModifyAt = DateTime.Now,
                Note = model.Note,
                Requestby=requestBy,
                Parking= parking,
                RequestAt= DateTime.Now,
                Status  = Status.Pending,
            } ; 

            await _dbContext.Requests.AddAsync(request);

            await _dbContext.SaveChangesAsync();

        }

        public async Task CancelRequest(string idString)
        {
            var updateRequest = await GetAsync(idString);
            updateRequest.Status = Status.Cancel;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(string idString)
        {
            var request = await GetAsync(idString);
            _dbContext.Remove(request);

           await _dbContext.SaveChangesAsync();

        }

        public async Task<ICollection<Request>> GetAllAsync()
        {
           return  await _dbContext.Requests.ToListAsync();
        }

        public async Task<Request> GetAsync(string idString)
        {
            if (string.IsNullOrEmpty(idString)) throw new ArgumentNullException();
            return await _dbContext.Requests.FirstAsync(c => c.ID.ToString().ToUpper().Trim().
                Equals(idString.ToUpper().Trim()
                ));
        }

        public async Task<ICollection<Request>> GetRequestToParking(string parkingID)
        {
            var requests = await _dbContext.Requests.Include(x=>x.Requestby).Where(x=>x.Parking.ID.ToString().Trim().ToLower()          
            .Equals(parkingID.Trim().ToLower())).ToListAsync();
            return requests;
        }


        public async Task<ICollection<Request>> GetRequestPendingToParking(string parkingID)
        {
            var requests = await _dbContext.Requests.Include(x => x.Requestby).Where(x => x.Parking.ID.ToString().Trim().ToLower()
            .Equals(parkingID.Trim().ToLower()) && x.Status==Status.Pending).ToListAsync();
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
            await _dbContext.SaveChangesAsync();
        }
    }

}
