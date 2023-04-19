using AutoMapper;
using Back_end.Common;
using Back_end.Entities;
using Back_end.Helper;
using Back_end.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Back_end.Respository
{
    public interface ICarRepository
    {
        Task AddAsync(CarDTO model, User ownner);
        Task<ICollection<Car>> GetCarByCarModel(string CarModelID);
        Task DeleteAsync(string idString);
        Task<ICollection<Car>> GetAllAsync();
        Task<ICollection<Car>> GetAllAvailable();
        Task<Car> GetAsync(string idString);
        ICollection<Car> PaginateAsync(ICollection<Car> source, int pageNo, int pageSize);
        ICollection<Car> SortAsync(DirectionOfSort direction, string factor);
        Task UpdateAsync(string id, CarDTO carDTO);
    }

    public class CarRepository : ICarRepository
    {
        private readonly ParkingDbContext _dbContext;
        private readonly ILogger<CarRepository> _logger;
        private readonly IMapper _mapper;

        public CarRepository(ParkingDbContext dbContext, ILogger<CarRepository> logger, IMapper mapper)
        {
            _dbContext = dbContext;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ICollection<Car>> GetCarByCarModel(string carModelID)
        {
            return await _dbContext.Cars.Include(c => c.CarModel).Include(c => c.ParkingDetails)
                .ThenInclude(pd => pd.Slot).Where(c=>c.CarModel.ID.ToString().Trim().ToLower().Equals(carModelID.ToLower().Trim())).ToListAsync();
        }

        public async Task AddAsync(CarDTO model, User ownner)
        {
            var carmodel = await _dbContext.CarModels.FirstAsync(c => c.ID.ToString().ToUpper().Trim().
                Equals(model.CarModelID.ToUpper().Trim()
                ));
            if (carmodel == null) throw new AppException("Wrong CarModel or CarModel not already existed");
            if (string.IsNullOrEmpty(model.CarNumber) || string.IsNullOrEmpty(model.CarModelID)) throw new ArgumentNullException("Null somefield");
            await _dbContext.Cars.AddAsync(
                new Back_end.Entities.Car()
                {
                    
                    CarNumber = model.CarNumber,
                    CarOwner = ownner,
                    LastModifyAt = DateTime.Now,
                    CarModel=carmodel
                   , Status = Status.Available,
                }
                );
           await _dbContext.SaveChangesAsync();
        }



        public async Task DeleteAsync(string idString)
        {
            if (string.IsNullOrEmpty(idString)) throw new ArgumentNullException();
            var deletedCar =await GetAsync(idString);

            _dbContext.Remove(deletedCar);
           await _dbContext.SaveChangesAsync();
        }

        public async Task<ICollection<Car>> GetAllAsync()
        {
            return await _dbContext.Cars.Include(c=>c.CarModel).Include(o=>o.CarOwner).Include(c=>c.ParkingDetails)
                .ThenInclude(pd=>pd.Slot)
                .ToListAsync();
        }
         public async Task<ICollection<Car>> GetAllAvailable()
        {
            return await _dbContext.Cars.Include(c=>c.CarModel).Include(o=>o.CarOwner).Where(p=>p.Status==Status.Available).ToListAsync();
        }

 

        public async Task<Car> GetAsync(string idString)
        {
            if (string.IsNullOrEmpty(idString)) throw new ArgumentNullException();
            return await _dbContext.Cars.Include(c => c.CarModel).Include(c => c.ParkingDetails)
                .ThenInclude(pd => pd.Slot).FirstAsync(c => c.ID.ToString().ToUpper().Trim().
                Equals(idString.ToUpper().Trim()
                ));
        }

        public ICollection<Car> PaginateAsync(ICollection<Car> source, int pageNo, int pageSize)
        {
            throw new NotImplementedException();
        }

        public ICollection<Car> SortAsync(DirectionOfSort direction, string factor)
        {
            throw new NotImplementedException();
        }


        public async Task UpdateAsync(string id, CarDTO carDTO)
        {
            if (string.IsNullOrEmpty(id)) throw new ArgumentNullException();
            var updateddCar = await GetAsync(id);

            updateddCar.CarNumber = carDTO.CarNumber;
            updateddCar.CarModel = await _dbContext.CarModels.FirstAsync(c => c.ID.ToString().ToUpper().Trim().
                Equals(carDTO.CarModelID.ToUpper().Trim()
                ));
            updateddCar.LastModifyAt = DateTime.Now;

            _dbContext.Cars.Update(updateddCar);
            await _dbContext.SaveChangesAsync();
        }
    }
}
