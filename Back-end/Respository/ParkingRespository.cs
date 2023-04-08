using AutoMapper;
using Back_end.Common;
using Back_end.Entities;
using Back_end.Helper;
using Back_end.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace Back_end.Respository
{
    public interface IParkingRespository
    {
        void AddAsync(ParkingModel model, User owner);
        Task DeleteAsync(string idString);
        Task<ICollection<Parking>> GetAllAsync();
        Parking GetAsync(string idString);
        Task<ICollection<Parking>> GetParkingByNameAsync(string searchText);
        ICollection<Parking> PaginateAsync(int pageNo, int pageSize);
        ICollection<Parking> SortAsync(DirectionOfSort direction, string factor);
        void UpdateAsync(string idString, ParkingModel updateModel);

        Task<ICollection<Parking>> GetListParkingPending();

        Task AproveParking(string? ID);

        Task CancelParkingInvalid(string? ID);
    }

    public class ParkingRespository : IParkingRespository
    {
        private readonly ParkingDbContext _dbContext;
        private readonly ILogger<ParkingRespository> _logger;
        private readonly IMapper _mapper;
        private readonly IImageRepository _imageRepository;

        public ParkingRespository(ParkingDbContext dbContext, ILogger<ParkingRespository> logger, IMapper mapper, IImageRepository imageRepository)
        {
            _dbContext = dbContext;
            _logger = logger;
            _mapper = mapper;
            _imageRepository = imageRepository;
        }

        public void AddAsync(ParkingModel model, User owner)
        {



            var parking = new Parking()
            {
                AddressDetail = model.AddressDetail,
                IsLegal =false,
                LAT = model.LAT,
                LON = model.LON,
                Owner = owner,
                Status = Status.Pending,
                Discription = model.Discription,
                LastModifyAt = DateTime.Now,
                ParkingName = model.ParkingName,

            };


            var images = new List<Image>();
            foreach (var url in model.imagesURLs)
            {
                var image = new Image()
                {
                    URL = url,
                    Parking = parking,

                };
                _imageRepository.AddAsync(image);
                images.Add(image);
            }

         
            owner.Parkings.Add(parking);

            _dbContext.Parkings.Add(parking);


            

        }



        public async Task DeleteAsync(string idString)
        {
            var parking = GetAsync(idString);
            var delteImages = parking.Images == null ? new List<Image>() : parking.Images;
             _dbContext.Images.RemoveRange(delteImages);
            _dbContext.Parkings.Remove(parking);
           
            await _dbContext.SaveChangesAsync();
        }

        public async Task<ICollection<Parking>> GetAllAsync()
        {
            return await _dbContext.Parkings.Include(p => p.ParkingManagers)
                 .Include(p => p.Feedbacks).ThenInclude(f => f.Images)
                .Include(p => p.Owner)
                .Include(p => p.Images).
                Include(p=>p.Requests)
                .Include(p => p.Slots).ThenInclude(s => s.CarModel)
                .ToListAsync();
        }



        public Parking GetAsync(string idString)
        {
            if (string.IsNullOrEmpty(idString)) throw new ArgumentNullException();
            return _dbContext.Parkings.Include(p => p.ParkingManagers)
                 .Include(p => p.Feedbacks).ThenInclude(f => f.Images)
                .Include(p => p.Owner)
                .Include(p => p.Images)
                .Include(p => p.Slots).ThenInclude(s => s.CarModel).FirstOrDefault(c => c.ID.ToString().ToUpper().Trim().
                Equals(idString.ToUpper().Trim()
                ));
        }

        public async Task<ICollection<Parking>> GetParkingByNameAsync(string searchText)
        {
            var searchTextHD = Regex.Replace(searchText, @"^\s+$", "", RegexOptions.IgnoreCase);
            var parkings = await _dbContext.Parkings.Include(p => p.ParkingManagers)
                .Include(p => p.Slots).ThenInclude(s => s.CarModel)

                .Include(p => p.Images)
                .Include(p => p.Owner).Where(p => p.ParkingName.Contains(searchTextHD.Trim()))
                .ToListAsync();
            return parkings;
        }

        public ICollection<Parking> PaginateAsync(int pageNo, int pageSize)
        {
            throw new NotImplementedException();
        }

        public ICollection<Parking> SortAsync(DirectionOfSort direction, string factor)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<Parking>> GetListParkingPending()
        {

            var pendingparkings =await _dbContext.Parkings.Where(p=>p.Status==Status.Pending).Include(p => p.ParkingManagers)
                 .Include(p => p.Feedbacks).ThenInclude(f => f.Images)
                .Include(p => p.Owner)
                .Include(p => p.Images)
                .Include(p => p.Slots).ThenInclude(s => s.CarModel).ToListAsync();
            return pendingparkings;
        }

        public async Task AproveParking(string? ID)
        {
            var parking = GetAsync(ID);
            parking.Status = Status.Available;
            parking.IsLegal = true;

           await _dbContext.SaveChangesAsync(true);
        }


        public async Task CancelParkingInvalid(string? ID)
        {
            var parking = GetAsync(ID);
            parking.Status = Status.Cancel;
            parking.IsLegal = false;

            await _dbContext.SaveChangesAsync(true);
        }
        public void UpdateAsync(string idString, ParkingModel updateModel)
        {

            var images = new List<Image>();


            var updateParking = GetAsync(idString);
            
            if (updateParking == null) throw new AppException("Not Found this parking");
            if (updateParking.IsLegal == false) throw new AppException("That Parking is Illigal");
            updateParking.AddressDetail = updateModel.AddressDetail;
            updateParking.LON = updateModel.LON;
            updateParking.LAT = updateModel.LAT;
            updateParking.IsLegal = updateModel.IsLegal;
            updateParking.Discription = updateModel.Discription;
            updateParking.ParkingName = updateModel.ParkingName;
            updateParking.Status = updateModel.Status;
            updateParking.LastModifyAt = DateTime.Now;

            var deletedimages = updateParking.Images == null ? new List<Image>() : updateParking.Images; 
            _imageRepository.DeleteRange(deletedimages);

            foreach (var url in updateModel.imagesURLs)
            {
                var image = new Image()
                {
                    URL = url,
                    Parking = updateParking
                };
                images.Add(image);
               
            }
            
            updateParking.Images = images;
            
            _dbContext.Update(updateParking);

            _imageRepository.AddRageAsync(images);
        }
    }
}
