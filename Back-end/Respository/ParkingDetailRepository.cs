using Back_end.Common;
using Back_end.Entities;
using Back_end.Models;
using Back_end.Models.User;

namespace Back_end.Respository
{
    public class ParkingDetailRepository : ICRUDSRespository<ParkingDetail, ParkingDetailModel>
    {
        public Task AddAsync(ParkingDetailModel model)
        {
            throw new NotImplementedException();
        }

       
        public Task DeleteAsync(string idString)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<ParkingDetail>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

  
        public Task<ParkingDetail> GetAsync(string idString)
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

        public Task UpdateAsync(string idString, ParkingDetailModel updateModel)
        {
            throw new NotImplementedException();
        }
    }
}
