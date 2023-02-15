using Back_end.Common;
using Back_end.Entities;

namespace Back_end.Respository
{
    public class CarRepository : ICRUDSRespository<Car>
    {
        public Task AddAsync()
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync()
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

        public ICollection<Car> PaginateAsync(ICollection<Car> source, int pageNo, int pageSize)
        {
            throw new NotImplementedException();
        }

        public ICollection<Car> SortAsync(DirectionOfSort direction, string factor)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync()
        {
            throw new NotImplementedException();
        }
    }
}
