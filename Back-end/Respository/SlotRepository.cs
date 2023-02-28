using AutoMapper;
using Back_end.Common;
using Back_end.Entities;
using Back_end.Helper;
using Back_end.Models;
using Microsoft.EntityFrameworkCore;

namespace Back_end.Respository
{
    public interface ISlotRepository
    {
        Task AddAsync(uint quantity, SlotModel model);
        Task DeleteAsync(string idString);
        Task<ICollection<Slot>> GetAllAsync();
        Task<Slot> GetAsync(string idString);
        ICollection<Slot> PaginateAsync(ICollection<Slot> source, int pageNo, int pageSize);
        ICollection<Slot> SortAsync(DirectionOfSort direction, string factor);
        Task UpdateAsync(string idString, SlotModel updateModel);
    }

    public class SlotRepository : ISlotRepository
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

        public async Task AddAsync(uint quantity, SlotModel model)
        {
            try
            {
                var carmodel = await _dbContext.CarModels.FirstOrDefaultAsync(c => c.ID.ToString().ToLower().Equals(model.CarModelID.ToLower()));
                var parking = await _dbContext.Parkings.FirstOrDefaultAsync(p => p.ID.ToString().ToLower().Equals(model.ParkingID.ToLower()));
                var modifyuer = await _dbContext.Users.FirstOrDefaultAsync(p => p.ID.ToString().ToLower().Equals(model.LastModifyByID.ToLower()));
                if (carmodel == null) throw new NullReferenceException();
                if (parking == null) throw new NullReferenceException();
                
                    var slot = new Slot()
                    {
                        CarModel = carmodel,
                        Parking = parking,
                        Discription = model.Discription,
                        LastModifyAt = DateTime.Now,
                        Price = model.Price,
                        Status = model.Status,
                        TypeOfSlot = model.TypeOfSlot,
                        LastModifyBy = modifyuer,
                    };

                await _dbContext.AddAsync(slot);



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
