using Back_end.Common;
using Back_end.Entities;
using Back_end.Helper;
using Back_end.Models;
using Microsoft.EntityFrameworkCore;

namespace Back_end.Respository
{
    public interface IParkingDetailRepository
    {
        Task AddAsync(ParkingDetailModel model);
        Task DeleteAsync(string idString);
        Task<ICollection<ParkingDetail>> GetAllAsync();

        Task<ICollection<ParkingDetail>> GetParkingDetailsByCar(string carID);
        Task<ICollection<ParkingDetail>> GetParkingDetailsBySlot(string SlotID);


        Task<ParkingDetail> GetAsync(string idString);
        ICollection<ParkingDetail> PaginateAsync(ICollection<ParkingDetail> source, int pageNo, int pageSize);
        ICollection<ParkingDetail> SortAsync(DirectionOfSort direction, string factor);
        Task UpdateAsync(string idString, ParkingDetailModel updateModel);

        ICollection<ParkingDetail> GetAllParkingDetailsOfParking(string parkingID);

        Task<ParkingDetail> CarOut(string id);
    }

    public class ParkingDetailRepository : IParkingDetailRepository
    {

        private readonly ICarRepository _carRepository;
        private readonly ISlotRepository _slotRepository;

        private readonly ParkingDbContext _dbContext;
        private readonly IParkingRespository _parkingRespository;

        public ParkingDetailRepository(ICarRepository carRepository,
            ISlotRepository slotRepository,IParkingRespository parkingRespository,

            ParkingDbContext dbContext)
        {
            _carRepository = carRepository;
            _slotRepository = slotRepository;
            _parkingRespository = parkingRespository;
            _dbContext = dbContext;
        }

        public async Task AddAsync(ParkingDetailModel model)
        {
            var car = await _carRepository.GetAsync(model.CarID);
            var slot = await _slotRepository.GetAsync(model.SlotID);

            if (slot.Status == Status.Parking) throw new AppException("Slot still have a car is parking") ;


            slot.Status = Status.NotAvailable;




            var parkingDetail = new ParkingDetail()
            {
                Car = car,
                Slot = slot,
                ParkingDate = model.ParkingDate,
                LastModifyAt = DateTime.Now,
                Note = model.Note,
                TotalPrice = slot.Price,

            };

             car.Status = Status.Parking;
            _dbContext.Cars.Update(car);
            _dbContext.ParkingDetails.Add(parkingDetail);
            _dbContext.SaveChanges(true);
        }

        public async Task<ParkingDetail> CarOut(string id)
        {
            var pd = await GetAsync(id);
            pd.PickUpDate = DateTime.Now;
            pd.Slot.Status = Status.Available;
            
            var totaldays = Math.Ceiling((DateTime.Now - pd.ParkingDate).TotalDays);
            if (totaldays < 1) totaldays = 1;

            pd.TotalPrice = totaldays * pd.Slot.Price;
            pd.Car.Status=Status.Available;

            _dbContext.ParkingDetails.Update(pd);
            _dbContext.SaveChanges();

            return pd;
        }

        public async Task DeleteAsync(string idString)
        {
            if (string.IsNullOrEmpty(idString)) throw new ArgumentNullException();
            var deletedParkingDetail = await GetAsync(idString);

            _dbContext.ParkingDetails.Remove(deletedParkingDetail);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<ICollection<ParkingDetail>> GetAllAsync()
        {
            return await _dbContext.ParkingDetails
                .Include(pd => pd.Car).ThenInclude(c=>c.CarModel)
                 .Include(pd => pd.Car).ThenInclude(c => c.CarOwner)
                .Include(pd => pd.Slot).ThenInclude(s=>s.Parking)
                
        .ToListAsync();
        }

        public ICollection<ParkingDetail> GetAllParkingDetailsOfParking(string parkingID)
        {
            var parking = _parkingRespository.GetAsync(parkingID);
            return parking.Slots.SelectMany(s=>s.ParkingDetail).ToList();
        }

        public async Task<ParkingDetail> GetAsync(string idString)
        {
            if (string.IsNullOrEmpty(idString)) throw new ArgumentNullException();
            return await _dbContext.ParkingDetails.Include(pd => pd.Car).ThenInclude(c => c.CarModel)
                 .Include(pd => pd.Car).ThenInclude(c => c.CarOwner)
                .Include(pd => pd.Slot).ThenInclude(s => s.Parking)
                .FirstAsync(c => c.ID.ToString().ToUpper().Trim().
                Equals(idString.ToUpper().Trim()
                ));
        }

        public async Task<ICollection<ParkingDetail>> GetParkingDetailsByCar(string carID)
        {
            return await _dbContext.ParkingDetails
                .Include(pd => pd.Car)
                .Include(pd => pd.Slot)
          
                .Where(pd => pd.Car.ID.ToString().ToUpper().Trim().Equals(carID.ToUpper().Trim())).
                ToListAsync();
        }

        public async Task<ICollection<ParkingDetail>> GetParkingDetailsBySlot(string SlotID)
        {
            return await _dbContext.ParkingDetails
                  .Include(pd => pd.Car)
                  .Include(pd => pd.Slot)

                  .Where(pd => pd.Slot.ID.ToString().ToUpper().Trim().Equals(SlotID.ToUpper().Trim())).
                  ToListAsync();
        }


        public ICollection<ParkingDetail> PaginateAsync(ICollection<ParkingDetail> source, int pageNo, int pageSize)
        {
            throw new NotImplementedException();
        }

        public ICollection<ParkingDetail> SortAsync(DirectionOfSort direction, string factor)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(string idString, ParkingDetailModel updateModel)
        {
            if (string.IsNullOrEmpty(idString)) throw new ArgumentNullException();
            if (updateModel == null) throw new ArgumentNullException();
            var updatedParkingModel = await GetAsync(idString);
            updatedParkingModel.PickUpDate = DateTime.Now;
        }
    }
}
