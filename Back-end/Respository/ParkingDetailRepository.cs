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

        Task<ICollection<ParkingDetail>> GetParkingDetailsByTimeFrame(string timeframe);
        Task<ParkingDetail> GetAsync(string idString);
        ICollection<ParkingDetail> PaginateAsync(ICollection<ParkingDetail> source, int pageNo, int pageSize);
        ICollection<ParkingDetail> SortAsync(DirectionOfSort direction, string factor);
        Task UpdateAsync(string idString, ParkingDetailModel updateModel);
    }

    public class ParkingDetailRepository : IParkingDetailRepository
    {

        private readonly ICarRepository _carRepository;
        private readonly ISlotRepository _slotRepository;
        private readonly ICRUDSRespository<TimeFrame, TimeFrameModel> _timeFrameRepository;
        private readonly ParkingDbContext _dbContext;

        public ParkingDetailRepository(ICarRepository carRepository,
            ISlotRepository slotRepository,
            ICRUDSRespository<TimeFrame, TimeFrameModel> timeFrameRepository,
            ParkingDbContext dbContext)
        {
            _carRepository = carRepository;
            _slotRepository = slotRepository;
            _timeFrameRepository = timeFrameRepository;
            _dbContext = dbContext;
        }

        public async Task AddAsync(ParkingDetailModel model)
        {
            var car = await _carRepository.GetAsync(model.CarID);
            var slot = await _slotRepository.GetAsync(model.SlotID);
            var timeFrame = await _timeFrameRepository.GetAsync(model.TimeFrameID);

            var parkingDetail = new ParkingDetail()
            {
                Car = car,
                Slot = slot,
                TimeFrame = timeFrame,
                ParkingDate = model.ParkingDate,
                PickUpDate = model.PickUpDate,
                LastModifyAt = DateTime.Now,
                Note = model.Note,

            };
            await _dbContext.ParkingDetails.AddAsync(parkingDetail);
            await _dbContext.SaveChangesAsync();
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
                .Include(pd => pd.Car)
                .Include(pd => pd.Slot)
                .Include(pd => pd.TimeFrame).
                ToListAsync();
        }


        public async Task<ParkingDetail> GetAsync(string idString)
        {
            if (string.IsNullOrEmpty(idString)) throw new ArgumentNullException();
            return await _dbContext.ParkingDetails.Include(pd => pd.Car)
                .Include(pd => pd.Slot)
                .Include(pd => pd.TimeFrame)
                .FirstAsync(c => c.ID.ToString().ToUpper().Trim().
                Equals(idString.ToUpper().Trim()
                ));
        }

        public async Task<ICollection<ParkingDetail>> GetParkingDetailsByCar(string carID)
        {
            return await _dbContext.ParkingDetails
                .Include(pd => pd.Car)
                .Include(pd => pd.Slot)
                .Include(pd => pd.TimeFrame)
                .Where(pd=>pd.Car.ID.ToString().ToUpper().Trim().Equals(carID.ToUpper().Trim())).
                ToListAsync();
        }

        public async Task<ICollection<ParkingDetail>> GetParkingDetailsBySlot(string SlotID)
        {
            return await _dbContext.ParkingDetails
                  .Include(pd => pd.Car)
                  .Include(pd => pd.Slot)
                  .Include(pd => pd.TimeFrame)
                  .Where(pd => pd.Slot.ID.ToString().ToUpper().Trim().Equals(SlotID.ToUpper().Trim())).
                  ToListAsync();
        }

        public async Task<ICollection<ParkingDetail>> GetParkingDetailsByTimeFrame(string timeframeID)
        {
            return await _dbContext.ParkingDetails
                  .Include(pd => pd.Car)
                  .Include(pd => pd.Slot)
                  .Include(pd => pd.TimeFrame)
                  .Where(pd => pd.TimeFrame.ID.ToString().ToUpper().Trim().Equals(timeframeID.ToUpper().Trim())).
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
