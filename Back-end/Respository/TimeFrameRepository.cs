using AutoMapper;
using Back_end.Common;
using Back_end.Entities;
using Back_end.Helper;
using Back_end.Models;
using Microsoft.EntityFrameworkCore;

namespace Back_end.Respository
{
    public class TimeFrameRepository : ICRUDSRespository<TimeFrame, TimeFrameModel>
    {

        private readonly ParkingDbContext _dbContext;
        private readonly ILogger<TimeFrameRepository> _logger;
        private readonly IMapper _mapper;

        public TimeFrameRepository(ParkingDbContext dbContext, ILogger<TimeFrameRepository> logger, IMapper mapper)
        {
            _dbContext = dbContext;
            _logger = logger;
            _mapper = mapper;
        }

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

        public async Task DeleteAsync(string idString)
        {
            try
            {
                var timeFrame = await GetAsync(idString);
                _dbContext.TimeFrames.Remove(timeFrame);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, "Has error:");
            }
        }

        public async Task<ICollection<TimeFrame>> GetAllAsync()
        {
            return await _dbContext.TimeFrames.Include(u => u.Parking).ToListAsync();
        }

        public async Task<TimeFrame> GetAsync(string idString)
        {

            if (string.IsNullOrEmpty(idString)) throw new ArgumentNullException();
            return await _dbContext.TimeFrames.Include(u => u.Parking).FirstAsync(c => c.ID.ToString().ToUpper().Trim().
                Equals(idString.ToUpper().Trim()
                ));
        }

        public ICollection<TimeFrame> PaginateAsync(ICollection<TimeFrame> source, int pageNo, int pageSize)
        {
            throw new NotImplementedException();
        }

        public ICollection<TimeFrame> SortAsync(DirectionOfSort direction, string factor)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(string idString, TimeFrameModel updateModel)
        {
            try
            {
                var updateTimeFrame = await GetAsync(idString);
                updateTimeFrame.Start = updateModel.Start;
                updateTimeFrame.Price = updateModel.Price;
                updateTimeFrame.End = updateModel.End;
                updateTimeFrame.Name = updateModel.Name;
                updateTimeFrame.LastModifyAt = DateTime.Now;
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, "Error");
            }
        }
    }
}
