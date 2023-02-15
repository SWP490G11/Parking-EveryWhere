using Back_end.Common;
using Back_end.Entities;
using Back_end.Models;

namespace Back_end.Respository
{
    public class SlotRepository : ICRUDSRespository<Slot,SlotModel>
    {


        public Task AddAsync(SlotModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Slot>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Slot> GetAsync()
        {
            throw new NotImplementedException();
        }

        public ICollection<Slot> PaginateAsync(ICollection<Slot> source, int pageNo, int pageSize)
        {
            throw new NotImplementedException();
        }

        public ICollection<Slot> SortAsync(DirectionOfSort direction, string factor)
        {
            throw new NotImplementedException();
        }



        public Task UpdateAsync(string idString, SlotModel updateModel)
        {
            throw new NotImplementedException();
        }
    }
}
