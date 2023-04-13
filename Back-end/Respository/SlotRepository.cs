using AutoMapper;
using Back_end.Common;
using Back_end.Entities;
using Back_end.Helper;
using Back_end.Models;
using Microsoft.EntityFrameworkCore;
using System;

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
        Task UpdateAsync(string idString, UpdatedSlotModel updateModel);

        Task<ICollection<Slot>> GetSlotByParkingAsync(string parkingID);

        ICollection<Slot> GetListSlotAvailable();

        ICollection<Slot> GetListSlotParking();


        void UpdatePriceOfSlot(double price,double updatePrice);

        void DeleteRangeAsync(double price);


    }

    public class GroupOfSlot {

        public string carModelID { get; set; }
        public TypeOfSlot TypeOfSlot { get; set; }

        public double Price { get; set; }
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


        public async Task DeleteAsync(string idString)
        {
            
                var timeFrame = await GetAsync(idString);
                _dbContext.Slots.Remove(timeFrame);
                await _dbContext.SaveChangesAsync();
          
        }

        public async Task<ICollection<Slot>> GetAllAsync()
        {
            var slots= await _dbContext.Slots.Include(p=>p.Parking).Include(s=>s.CarModel).Include(p=>p.ParkingDetail).ToListAsync();

            return slots;
        }

        public async Task<ICollection<Slot>> GetSlotByParkingAsync(string parkingID)
        {
            var slots = await _dbContext.Slots
                .Include(p => p.Parking)
                .Include(s => s.CarModel).Include(p => p.ParkingDetail)
                .Where(s=>s.Parking.ID.ToString()
                .ToLower().Trim().Equals(parkingID
                .ToLower().Trim())).ToListAsync();

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



        public async Task UpdateAsync(string idString, UpdatedSlotModel updateModel)
        {
            var updated = await GetAsync(idString);
            updated.TypeOfSlot = updateModel.TypeOfSlot;
            updated.Status = updated.Status;
            updated.Price = updateModel.Price;
            updated.Discription = updated.Discription;

            var carModel = _dbContext.CarModels.First(cm=>cm.ID.ToString().ToLower().Equals(updateModel.CarModelID.ToLower()));
            if (carModel != null) updated.CarModel = carModel;

            _dbContext.Slots.Update(updated);
            _dbContext.SaveChanges();


        }

        public ICollection<Slot> GetListSlotAvailable()
        {
            var slots =  _dbContext.Slots
               .Include(p => p.Parking)
               .Include(s => s.CarModel).Include(p => p.ParkingDetail)
               .Where(s => s.Status==Status.Available).ToList();

            return slots;
        }

        public ICollection<Slot> GetListSlotParking()
        {
            var slots = _dbContext.Slots
               .Include(p => p.Parking)
               .Include(s => s.CarModel).Include(p => p.ParkingDetail)
               .Where(s => s.Status == Status.Parking).ToList();

            return slots;
        }

        public void UpdatePriceOfSlot(double oldprice,double updatePrice)
        {
            var updated = _dbContext.Slots.Where(s=>s.Price == oldprice).ToList();

            foreach (var slot in updated)
            {
                slot.Price = updatePrice;
            }

            _dbContext.Slots.UpdateRange(updated);
            _dbContext.SaveChanges();

        }

        public void DeleteRangeAsync(double price)
        {
            var deleted = _dbContext.Slots.Where(s => s.Price == price).ToList();
            _dbContext.Slots.RemoveRange(deleted);
            _dbContext.SaveChanges();
        }
    }

    public class UpdatedSlotModel
    {
        public Status Status { get; set; }

        public TypeOfSlot TypeOfSlot { get; set; }

        public string Discription { get; set; }


        public double Price { get; set; }

        public string? CarModelID { get; set; }

        public string? LastModifyByID { get; set; }
    }
}
