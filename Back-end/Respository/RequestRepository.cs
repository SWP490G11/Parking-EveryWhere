using Back_end.Common;
using Back_end.Entities;

namespace Back_end.Respository
{
    public class RequestRepository : ICRUDSRespository<Request>
    {
        public Task AddAsync()
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Request>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Request> GetAsync()
        {
            throw new NotImplementedException();
        }

        public ICollection<Request> PaginateAsync(ICollection<Request> source, int pageNo, int pageSize)
        {
            throw new NotImplementedException();
        }

        public ICollection<Request> SortAsync(DirectionOfSort direction, string factor)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync()
        {
            throw new NotImplementedException();
        }
    }
}
