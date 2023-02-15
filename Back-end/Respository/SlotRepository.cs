using Back_end.Common;
using Back_end.Entities;

namespace Back_end.Respository
{
    public class SlotRepository : ICRUDSRespository<Slot>
    {
        public Task AddAsync()
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

        public Task UpdateAsync()
        {
            throw new NotImplementedException();
        }
    }
}
