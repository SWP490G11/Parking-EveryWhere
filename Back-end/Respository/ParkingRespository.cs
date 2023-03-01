using AutoMapper;
using Back_end.Common;
using Back_end.Entities;
using Back_end.Helper;
using Back_end.Models;
using Microsoft.EntityFrameworkCore;

namespace Back_end.Respository
{
    public class ParkingRespository : IParkingRespository
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

        public async Task AddAsync(ParkingModel model,User owner)
        {
            try
            {
             
                
                var parking = new Parking()
                {
                    AddressDetail = model.AddressDetail,
                    IsLegal = model.IsLegal,
                    LAT = model.LAT,
                    LON = model.LON,
                    Owner = owner,
                    Status = Status.Available,
                    Discription = model.Discription,
                    LastModifyAt = DateTime.Now,
                    ParkingName = model.ParkingName,

                };

                owner.Parkings.Add(parking);

                await _dbContext.Parkings.AddAsync(parking);

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
                var parking = await GetAsync(idString);
                _dbContext.Parkings.Remove(parking);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, "Has error:");
            }
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
