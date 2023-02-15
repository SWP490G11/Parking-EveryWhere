using Back_end.Common;
using Back_end.Entities;

namespace Back_end.Respository
{
    public class ParkingRespository : ICRUDSRespository<Parking>
    {
        public Task AddAsync()
        {  throw new NotImplementedException(); }

        public Task DeleteAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Parking>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Parking> GetAsync()
        {
            throw new NotImplementedException();
        }

        public ICollection<Parking> PaginateAsync(ICollection<Parking> source, int pageNo, int pageSize)
        {
            throw new NotImplementedException();
        }

        public ICollection<Parking> SortAsync(DirectionOfSort direction, string factor)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync()
        {
            throw new NotImplementedException();
        }
    }
}
