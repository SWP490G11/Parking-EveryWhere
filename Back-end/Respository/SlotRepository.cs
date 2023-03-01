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
                var carmodel = await _dbContext.CarModels.FirstOrDefaultAsync(c => c.ID.ToString().ToLower().Trim().Equals(model.CarModelID.ToLower().Trim()));
                var parking = await _dbContext.Parkings.FirstOrDefaultAsync(p => p.ID.ToString().ToLower().Trim().Equals(model.ParkingID.ToLower().Trim()));
                var modifyuer = await _dbContext.Users.FirstOrDefaultAsync(p => p.ID.ToString().ToLower().Trim().Equals(model.LastModifyByID.ToLower().Trim()));
                

                ICollection<Slot> slots = new List<Slot>();

                for (int i = 0; i < quantity; i++)
                {
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

                    slots.Add(slot);
                }
                   

                await _dbContext.AddRangeAsync(slots);



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
            var slots= await _dbContext.Slots.Include(p=>p.Parking).Include(s=>s.CarModel).ToListAsync();

            return slots;
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
