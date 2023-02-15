using Back_end.Authorization;
using Back_end.Common;
using Back_end.Entities;
using Back_end.Helper;
using Back_end.Models;

namespace Back_end.Respository
{
    public class CarModelRespository : ICRUDSRespository<CarModel,CarModelx2>
    {
        private readonly ParkingDbContext _dbContext;
        private readonly ILogger<UserRespository> _logger;

        public Task AddAsync(CarModelx2 model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<CarModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CarModel> GetAsync()
        {
            throw new NotImplementedException();
        }

        public ICollection<CarModel> PaginateAsync(ICollection<CarModel> source, int pageNo, int pageSize)
        {
            throw new NotImplementedException();
        }

        public ICollection<CarModel> SortAsync(DirectionOfSort direction, string factor)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(string id,CarModelx2 model)
        {
            throw new NotImplementedException();
        }
    }
}
