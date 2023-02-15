using Back_end.Common;
using Back_end.Entities;

namespace Back_end.Respository
{
    public class ParkingDetailRepository : ICRUDSRespository<ParkingDetail>
    {
        public Task AddAsync()
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<ParkingDetail>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ParkingDetail> GetAsync()
        {
            throw new NotImplementedException();
        }

        public ICollection<ParkingDetail> PaginateAsync(ICollection<ParkingDetail> source, int pageNo, int pageSize)
        {
            throw new NotImplementedException();
        }

        public ICollection<ParkingDetail> SortAsync(DirectionOfSort direction, string factor)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync()
        {
            throw new NotImplementedException();
        }
    }
}
