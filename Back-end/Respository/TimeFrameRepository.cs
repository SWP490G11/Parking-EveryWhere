using Back_end.Common;

namespace Back_end.Respository
{
    public class TimeFrameRepository : ICRUDSRespository<TimeFrameRepository>
    {
        public Task AddAsync()
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<TimeFrameRepository>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TimeFrameRepository> GetAsync()
        {
            throw new NotImplementedException();
        }

        public ICollection<TimeFrameRepository> PaginateAsync(ICollection<TimeFrameRepository> source, int pageNo, int pageSize)
        {
            throw new NotImplementedException();
        }

        public ICollection<TimeFrameRepository> SortAsync(DirectionOfSort direction, string factor)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync()
        {
            throw new NotImplementedException();
        }
    }
}
