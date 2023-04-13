using AutoMapper;
using Back_end.Authorization;
using Back_end.Common;
using Back_end.Entities;
using Back_end.Helper;
using Back_end.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Back_end.Respository
{
    public class CarModelRespository : ICRUDSRespository<CarModel,CarModelx2>
    {
        private readonly ParkingDbContext _dbContext;
        private readonly ILogger<CarModelRespository> _logger;
        private readonly IMapper _mapper;
public CarModelRespository(ParkingDbContext dbContext, ILogger<CarModelRespository> logger, IMapper mapper)
        {
            _dbContext = dbContext;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task AddAsync(CarModelx2 model)
        {
           
                await _dbContext.CarModels.AddAsync(_mapper.Map<CarModel>(model));
                await _dbContext.SaveChangesAsync();
           
        }

       

        public async Task DeleteAsync(string idString)
        {
           
                if (string.IsNullOrEmpty(idString)) throw new ArgumentNullException();
                var carModel = await GetAsync(idString);
            if (carModel == null) throw new AppException("Wrong Id");
                _dbContext.CarModels.Remove(carModel);
              
                
                await _dbContext.SaveChangesAsync();
                

        }

        public async Task<ICollection<CarModel>> GetAllAsync()
        {
            return await _dbContext.CarModels.ToListAsync() ;
        }

    
        public async Task<CarModel> GetAsync(string idString)
        {
            if (string.IsNullOrEmpty(idString)) throw new ArgumentNullException();
            var carmodel= await _dbContext.CarModels.FirstAsync(c => c.ID.ToString().ToUpper().Trim().
                Equals(idString.ToUpper().Trim()
                ));

            return carmodel;
        }

        public ICollection<CarModel> PaginateAsync(ICollection<CarModel> source, int pageNo, int pageSize)
        {
            throw new NotImplementedException();
        }

        public ICollection<CarModel> SortAsync(DirectionOfSort direction, string factor)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(string idString, CarModelx2 model)
        {
            
                var carModel = await GetAsync(idString);
            if (carModel == null) throw new AppException("Wrong Id");

           
                carModel.Model = model.Model;
                carModel.Discript = model.Discript;
                carModel.LastModifyAt = DateTime.Now;

                _dbContext.CarModels.Update(carModel);
                await _dbContext.SaveChangesAsync();
         
        }
    }
}
