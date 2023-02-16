using Back_end.Common;
using Back_end.Entities;
using Back_end.Models;

namespace Back_end.Respository
{
    public class RequestRepository : ICRUDSRespository<Request,RequestModel>
    {
      

        public Task AddAsync(RequestModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(string idString)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Request>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Request> GetAsync(string idString)
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

      

        public Task UpdateAsync(string idString, RequestModel updateModel)
        {
            throw new NotImplementedException();
        }
    }
}
