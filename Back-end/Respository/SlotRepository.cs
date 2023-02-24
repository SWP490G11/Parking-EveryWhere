using AutoMapper;
using Back_end.Common;
using Back_end.Entities;
using Back_end.Helper;
using Back_end.Models;
using Microsoft.EntityFrameworkCore;

namespace Back_end.Respository
{
    public class SlotRepository : ICRUDSRespository<Slot,SlotModel>
    {
        private readonly ParkingDbContext _dbContext;
        private readonly ILogger<SlotRepository> _logger;
        private readonly IMapper _mapper;

        public SlotRepository(ParkingDbContext dbContext, ILogger<SlotRepository> logger, IMapper mapper)
        {
            _dbContext = dbContext;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task AddAsync(SlotModel model)
        {
            try
            {
                await _dbContext.Slots.AddAsync(_mapper.Map<Slot>(model));
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
                _dbContext.Slots.Remove(timeFrame);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, "Has error:");
            }
        }

        public async Task<ICollection<Slot>> GetAllAsync()
        {
            return await _dbContext.Slots.ToListAsync();
        }

      

        public async Task<Slot> GetAsync(string idString)
        {
            if (string.IsNullOrEmpty(idString)) throw new ArgumentNullException();
            return await _dbContext.Slots.FirstAsync(c => c.ID.ToString().ToUpper().Trim().
                Equals(idString.ToUpper().Trim()
                ));
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
