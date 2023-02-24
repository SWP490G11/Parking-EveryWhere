using AutoMapper;
using Back_end.Common;
using Back_end.Entities;
using Back_end.Helper;
using Back_end.Models;
using Microsoft.EntityFrameworkCore;

namespace Back_end.Respository
{
    public class ParkingRespository : ICRUDSRespository<Parking,ParkingModel>
    {
        private readonly ParkingDbContext _dbContext;
        private readonly ILogger<ParkingRespository> _logger;
        private readonly IMapper _mapper;

        public ParkingRespository(ParkingDbContext dbContext, ILogger<ParkingRespository> logger, IMapper mapper)
        {
            _dbContext = dbContext;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task AddAsync(ParkingModel model)
        {
            try
            {
                await _dbContext.Parkings.AddAsync(_mapper.Map<Parking>(model));
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

        public async Task<ICollection<Parking>> GetAllAsync()
        {
            return await _dbContext.Parkings.ToListAsync();
        }

     

        public async Task<Parking> GetAsync(string idString)
        {
            if (string.IsNullOrEmpty(idString)) throw new ArgumentNullException();
            return await _dbContext.Parkings.FirstAsync(c => c.ID.ToString().ToUpper().Trim().
                Equals(idString.ToUpper().Trim()
                ));
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
