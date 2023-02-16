using Back_end.Common;
using Back_end.Entities;
using Back_end.Models;

namespace Back_end.Respository
{
    public class TimeFrameRepository : ICRUDSRespository<TimeFrame, TimeFrameModel>
    {
        public Task AddAsync(TimeFrameModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(string idString)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<TimeFrame>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TimeFrame> GetAsync(string idString)
        {
            throw new NotImplementedException();
        }

        public ICollection<TimeFrame> PaginateAsync(ICollection<TimeFrame> source, int pageNo, int pageSize)
        {
            throw new NotImplementedException();
        }

        public ICollection<TimeFrame> SortAsync(DirectionOfSort direction, string factor)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(string idString, TimeFrameModel updateModel)
        {
            throw new NotImplementedException();
        }
    }
}
