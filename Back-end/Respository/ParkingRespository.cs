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
        Task AddAsync(ParkingModel model, User owner);
        Task DeleteAsync(string idString);
        Task<ICollection<Parking>> GetAllAsync();

        Task<ICollection<Parking>> GetParkingByNameAsync(string searchText);
        
        Task<Parking> GetAsync(string idString);
        ICollection<Parking> PaginateAsync( int pageNo, int pageSize);
        ICollection<Parking> SortAsync(DirectionOfSort direction, string factor);
        Task UpdateAsync(string idString, ParkingModel updateModel);
    }

    public class ParkingRespository :  IParkingRespository
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

        public async Task AddAsync(ParkingModel model, User owner)
        {
            
                var images = new List<Image>();

                foreach (var url in model.imagesURLs)
                {
                    var image = new Image()
                    {
                        URL = url.Trim(),
                        
                    };
                    images.Add(image);
                }

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

                foreach (var image in images)
                {
                    image.Parking = await GetAsync(parking.ID.ToString());
                }

                parking.Images = images;

               await _dbContext.Images.AddRangeAsync(images);
                await _dbContext.SaveChangesAsync();


           
        }



        public async Task DeleteAsync(string idString)
        {
                var parking = await GetAsync(idString);
                _dbContext.Parkings.Remove(parking);
                await _dbContext.SaveChangesAsync();  
        }

        public async Task<ICollection<Parking>> GetAllAsync()
        {
            return await _dbContext.Parkings.Include(p => p.ParkingManagers)
                .Include(p => p.Slots).ThenInclude(s => s.CarModel)
                .Include(p => p.TimeFrames)
                .Include(p => p.Owner)
                .ToListAsync();
        }



        public async Task<Parking> GetAsync(string idString)
        {
            if (string.IsNullOrEmpty(idString)) throw new ArgumentNullException();
            return await _dbContext.Parkings.FirstAsync(c => c.ID.ToString().ToUpper().Trim().
                Equals(idString.ToUpper().Trim()
                ));
        }

        public async Task<ICollection<Parking>> GetParkingByNameAsync(string searchText)
        {
            var searchTextHD = Regex.Replace(searchText, @"^\s+$", "", RegexOptions.IgnoreCase); 
            var parkings =  await _dbContext.Parkings.Include(p => p.ParkingManagers)
                .Include(p => p.Slots).ThenInclude(s => s.CarModel)
                .Include(p => p.TimeFrames)
                .Include(p=>p.Images)
                .Include(p => p.Owner).Where(p=>p.ParkingName.Contains(searchTextHD.Trim()))
                .ToListAsync();
            return parkings;
        }

        public ICollection<Parking> PaginateAsync( int pageNo, int pageSize)
        {
            throw new NotImplementedException();
        }

        public ICollection<Parking> SortAsync(DirectionOfSort direction, string factor)
        {
            throw new NotImplementedException();
        }


        public async Task UpdateAsync(string idString, ParkingModel updateModel)
        {
            var updateParking = await GetAsync(idString);
            if (updateParking == null) throw new AppException("Not Found this parking");
            updateParking.AddressDetail = updateModel.AddressDetail;
            updateParking.LON=updateModel.LON;
            updateParking.LAT = updateModel.LAT;
            updateParking.IsLegal = updateModel.IsLegal;
            updateParking.Discription = updateModel.Discription;
            updateParking.ParkingName = updateModel.ParkingName;
            updateParking.Status = updateModel.Status;
            updateParking.LastModifyAt = DateTime.Now;
            

            _dbContext.Update(updateParking);
            await _dbContext.SaveChangesAsync();
        }
    }
}
