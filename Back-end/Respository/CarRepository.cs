using AutoMapper;
using Back_end.Common;
using Back_end.Entities;
using Back_end.Helper;
using Back_end.Models;

namespace Back_end.Respository
{
    public class CarRepository : ICRUDSRespository<Car,CarDTO>
    {
        private readonly ParkingDbContext _dbContext;
        private readonly ILogger<CarRepository> _logger;
        private readonly IMapper _mapper;

        public Task AddAsync(CarDTO model)
        {
            throw new NotImplementedException();
        }

       

        public Task DeleteAsync(string idString)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Car>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Car> GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Car> GetAsync(string idString)
        {
            throw new NotImplementedException();
        }

        public ICollection<Car> PaginateAsync(ICollection<Car> source, int pageNo, int pageSize)
        {
            throw new NotImplementedException();
        }

        public ICollection<Car> SortAsync(DirectionOfSort direction, string factor)
        {
            throw new NotImplementedException();
        }


        public Task UpdateAsync(string id,CarDTO carDTO)
        {
            throw new NotImplementedException();
        }
    }
}
