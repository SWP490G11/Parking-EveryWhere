using AutoMapper;
using Back_end.Common;
using Back_end.Entities;
using Back_end.Helper;
using Back_end.Models;

namespace Back_end.Respository
{
    public class TimeFrameRepository : ICRUDSRespository<TimeFrame, TimeFrameModel>
    {

        private readonly ParkingDbContext _dbContext;
        private readonly ILogger<TimeFrameRepository> _logger;
        private readonly IMapper _mapper;
        public async Task AddAsync(TimeFrameModel model)
        {
            try
            {
                await _dbContext.TimeFrames.AddAsync(_mapper.Map<TimeFrame>(model));
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, "Has error:");
            }
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
