using AutoMapper;
using Back_end.Common;
using Back_end.Entities;
using Back_end.Helper;
using Back_end.Models;
using Back_end.Models.User;
using Back_end.Respository;
using Back_end.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Packaging;

namespace Back_end.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParkingController : ControllerBase
    {

        private readonly IParkingRespository _respository;
        private readonly IMapper _mapper;
        private readonly IImageService _imageService;
        private readonly ParkingDbContext _dbContext;

        public ParkingController(IParkingRespository respository, IMapper mapper, IImageService imageService, ParkingDbContext dbContext)
        {
            _respository = respository;
            _mapper = mapper;
            _imageService = imageService;
            _dbContext = dbContext;
        }

        [HttpGet("/parkings-of-owner")]
        [Authorization.Authorize(Role.Admin, Role.ParkingOwner)]
        public async Task<IActionResult> GetParkingsOfOwnerAsync()
        {

            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");

            var user = mwi.User;
            if (user == null) return NotFound();




            return Ok(user.Parkings.Select(p => new
            {
                ParkingID = p.ID,
                p.ParkingName,
                LAT = p.LAT,
                IsLegal = p.IsLegal,
                p.LON,
                p.Status,
                p.Discription,
                p.AddressDetail,
                p.ParkingManagers,
                p.Feedbacks,
                p.TimeFrames,
                NumberOfRoofSlot = p.Slots.Count(x => x.TypeOfSlot == TypeOfSlot.ROOFED),
                NumberOfNonRoofSlot = p.Slots.Count(x => x.TypeOfSlot == TypeOfSlot.NONROOF),
                NumberOfAvailableSlot = p.Slots.Count(x => x.Status == Status.Available),
                NumberOfNotAvailableSlot = p.Slots.Count(x => x.Status == Status.NotAvailable),

            }


                ).ToList()) ;
        }

        [HttpGet("/parking-manager-of-parking/{id}")]
        [Authorization.Authorize(Role.Admin, Role.ParkingOwner)]
        public async Task<IActionResult> GetParkingManagerOfParking(string id)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");

            var user = mwi.User;
            if (user == null) return NotFound();

            var parking = await _respository.GetAsync(id);


            return Ok(parking.ParkingManagers);
        }

        [HttpGet("/parking-manager-of-owner")]
        [Authorization.Authorize(Role.Admin, Role.ParkingOwner)]
        public async Task<IActionResult> GetParkingManagerOfOwner()
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");

            var user = mwi.User;
            if (user == null) return NotFound();


            return Ok(user.Parkings.Select(p=>p.ParkingManagers));
        }


        [HttpGet("/parkings")]
        [Authorization.Authorize(Role.Admin, Role.ParkingOwner, Role.Customer,Role.ParkingManager)]
        public async Task<IActionResult> GetAll()
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            var parkings = await _respository.GetAllAsync();

            return Ok(parkings.Select(p => new
            {
                ParkingID = p.ID,
                p.ParkingName,
                LAT = p.LAT,
                IsLegal = p.IsLegal,
                p.LON,
                p.Status,
                p.Discription,
                p.AddressDetail,
                p.ParkingManagers,
                p.Feedbacks,
                p.TimeFrames,
                NumberOfRoofSlot = p.Slots.Count(x => x.TypeOfSlot == TypeOfSlot.ROOFED),
                NumberOfNonRoofSlot = p.Slots.Count(x => x.TypeOfSlot == TypeOfSlot.NONROOF),
                NumberOfAvailableSlot = p.Slots.Count(x => x.Status == Status.Available),
                NumberOfNotAvailableSlot = p.Slots.Count(x => x.Status == Status.Available),

            }));
        }

        [HttpGet("/parking/{id}")]
        [Authorization.Authorize(Role.Admin)]
        public async Task<IActionResult> Get(string id)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            var parking = await _respository.GetAsync(id);

            return Ok(parking);
        }


        [HttpGet("/parkings/{name}")]
        [Authorization.Authorize(Role.Admin)]
        public async Task<IActionResult> GetParkings(string name)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            var parkings = await _respository.GetParkingByNameAsync(name);

            return Ok(parkings.Select(p => new
            {
                ParkingID = p.ID,
                p.ParkingName,
                LAT = p.LAT,
                IsLegal = p.IsLegal,
                p.LON,
                p.Status,
                p.Discription,
                p.AddressDetail,
                p.ParkingManagers,
                p.Feedbacks,
                p.TimeFrames,
                Slot = p.Slots.Select(s =>
              new
              {
                  SlotID = s.ID,
                  CarModelID = s.CarModel.ID,
                  CarModelName = s.CarModel.Model,
                  s.TypeOfSlot,
                  s.Status,
                  s.Discription,
                  s.LastModifyAt

              }),
            }));
        }

        [HttpPost("/parking")]
        [Authorization.Authorize(Role.Admin, Role.ParkingOwner)]
        public async Task<IActionResult> Add(ParkingModel model)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            if (!ModelState.IsValid) return BadRequest(ModelState);


            await _respository.AddAsync(model, mwi.User);
            return Ok("Add Success");
        }

        [HttpPut("/parking/{id}")]
        [Authorization.Authorize(Role.Admin, Role.ParkingOwner)]
        public async Task<IActionResult> Update(string id, ParkingModel model)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            if (!ModelState.IsValid) return BadRequest(ModelState);
            await _respository.UpdateAsync(id, model);
            return Ok("Update Success");
        }


        [HttpDelete("/parking/{id}")]
        [Authorization.Authorize(Role.Admin, Role.ParkingOwner)]
        public async Task<IActionResult> Delete(string id)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            if (!ModelState.IsValid) return BadRequest(ModelState);
            await _respository.DeleteAsync(id);
            return Ok("Deletes Success");
        }

        [Authorization.Authorize(Role.Admin, Role.ParkingOwner, Role.Customer, Role.ParkingManager)]
        [HttpPost("[action]")]
        public async Task<IActionResult> UploadImage(IFormFile file)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");

            var result = await _imageService.UploadImageAsync(file);
            var user = mwi.User;

            var allowedExtensions = new[] { ".jpg", ".jpeg", ".png", ".gif" };
            var fileExtension = Path.GetExtension(file.FileName);

            if (!allowedExtensions.Contains(fileExtension.ToLower()))
            {
                // File uploaded is not an image file.
                // Handle the error as desired (e.g. return an error message).
                return BadRequest("Choice wrong fomart file");
            }

            var image = new Image()
            {
                PublicID = result.PublicId,
                URL = result.SecureUri.AbsoluteUri,
                Parking = user.Parking,
            };

            if (user.Images.Count == 0) image.IsMain = true;
            if (result.Error != null) return BadRequest(result.Error.Message);


            user.Images.Add(image);
            await _dbContext.Images.AddAsync(image);
            await _dbContext.SaveChangesAsync();


            return Ok(image);
        }


        [Authorization.Authorize(Role.Admin, Role.ParkingOwner, Role.Customer, Role.ParkingManager)]
        [HttpPost("[action]")]
        public async Task<IActionResult> UploadRangeImage(IFormFileCollection files)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");

            var images = new List<Image>();
            var allowedExtensions = new[] { ".jpg", ".jpeg", ".png", ".gif" };
            var user = mwi.User;
            foreach (var file in files)
            {
                var result = await _imageService.UploadImageAsync(file);

                var fileExtension = Path.GetExtension(file.FileName);

                if (!allowedExtensions.Contains(fileExtension.ToLower()))
                {
                    // File uploaded is not an image file.
                    // Handle the error as desired (e.g. return an error message).
                    return BadRequest("Choice wrong fomart file");
                }

                var image = new Image()
                {
                    PublicID = result.PublicId,
                    URL = result.SecureUri.AbsoluteUri,
                    Parking = mwi.User.Parking,
                };

                if (user.Images.Count == 0) image.IsMain = true;
                if (result.Error != null) return BadRequest(result.Error.Message);
            }





            user.Images.AddRange(images);
            await _dbContext.Images.AddRangeAsync(images);
            await _dbContext.SaveChangesAsync();


            return Ok(images);
        }


    }
}
