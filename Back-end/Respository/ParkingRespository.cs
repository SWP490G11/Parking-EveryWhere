using Back_end.Common;
using Back_end.Entities;
using Back_end.Models;

namespace Back_end.Respository
{
    public class ParkingRespository : ICRUDSRespository<Parking,ParkingModel>
    {
       

        public Task AddAsync(ParkingModel model)
        {
            throw new NotImplementedException();
        }

     

        public Task DeleteAsync(string idString)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Parking>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

     

        public Task<Parking> GetAsync(string idString)
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


        public Task UpdateAsync(string idString, ParkingModel updateModel)
        {
            throw new NotImplementedException();
        }
    }
}
