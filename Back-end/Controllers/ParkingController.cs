using AutoMapper;
using Back_end.Common;
using Back_end.Helper;
using Back_end.Models;
using Back_end.Models.User;
using Back_end.Respository;
using Back_end.Services;
using Microsoft.AspNetCore.Mvc;

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
        [Authorization.Authorize(Role.Admin, Role.ParkingOwner, Role.ParkingManager)]
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
                ParkingManagers = p.ParkingManagers.Select(
                    pm => new
                    {
                        pm.ID,
                        FullName = pm.LastName + " " + pm.FirstName,
                        PhoneNumber = pm.PhoneNumber,
                        pm.Email,
                        ImageUrl = pm.Image.URL,
                    }
                    )
               ,
                Feedbacks = p.Feedbacks/*.Select(
                    fb => new
                    {
                        fb.ID,
                        fb.Rating,
                        fb.Content,
                        FeebackBy = fb.FeedbackBy.ID.ToString()
                    }
                    )*/,

                PriceDetails = p.Slots.GroupBy(s => s.Price).Select(
                   group => new
                   {
                       Price = group.Key,
                       SlotType = group.FirstOrDefault().TypeOfSlot,
                       NumberOfSlots = group.Count(),
                       NumberOfSlotAvailable = group.Count(s => s.Status == Status.Available)

                   }
                    ),
                ImageUrls = p.Images.Select(i => i.URL).ToList(),

            }));
        }

        [HttpGet("/parkings-of-owner-available")]
        [Authorization.Authorize(Role.Admin, Role.ParkingOwner, Role.ParkingManager)]
        public async Task<IActionResult> GetParkingsOfOwnerAvaiable()
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


                ImageUrls = p.Images.Select(i => i.URL).FirstOrDefault(),

            }).Where(p => p.Status == Status.Available));
        }

        [HttpGet("/parking-manager-of-parking/{id}")]
        [Authorization.Authorize(Role.Admin, Role.ParkingOwner)]
        public IActionResult GetParkingManagerOfParking(string id)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");

            var user = mwi.User;
            if (user == null) return NotFound();

            var parking = _respository.GetAsync(id);
            if (parking == null) return NotFound();

            return Ok(parking.ParkingManagers);
        }

        [HttpGet("/parking-manager-of-owner")]
        [Authorization.Authorize(Role.Admin, Role.ParkingOwner, Role.ParkingManager)]
        public async Task<IActionResult> GetParkingManagerOfOwner()
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");

            var user = mwi.User;
            if (user == null) return NotFound();


            return Ok(user.Parkings.SelectMany(p => p.ParkingManagers)/*.Select(pm =>
            new { pm.ID,FullName = pm.LastName + pm.FirstName,pm.UserName,WorkIn= pm.Parking.ID,pm.Gender,ImageURL=pm.Image.URL,pm.CitizenID,pm.DateOfBirth,
            pm.PhoneNumber,pm.Email
            }
            )*/
                );
        }


        [HttpGet("/parkings")]
        [Authorization.Authorize(Role.Admin, Role.ParkingOwner, Role.Customer, Role.ParkingManager)]
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
                ParkingManagers = p.ParkingManagers.Select(
                    pm => new
                    {
                        pm.ID,
                        FullName = pm.LastName + " " + pm.FirstName,
                        PhoneNumber = pm.PhoneNumber,
                        pm.Email,
                        ImageUrl = pm.Image.URL,
                    }
                    ),
                Feedbacks = p.Feedbacks/*.Select(
                    fb => new
                    {
                        fb.ID,
                        fb.Rating,
                        fb.Content,
                        FeebackBy = fb.FeedbackBy.ID.ToString()
                    }
                    )*/,

                PriceDetails = p.Slots.GroupBy(s => s.Price).Select(
                   group => new
                   {
                       Price = group.Key,
                       SlotType = group.FirstOrDefault().TypeOfSlot,
                       NumberOfSlots = group.Count(),
                       NumberOfSlotAvailable = group.Count(s => s.Status == Status.Available)

                   }
                    ),

                ImageUrls = p.Images.Select(i => i.URL).ToList(),

            }));
        }

        [HttpGet("/parkings-available")]
        [Authorization.Authorize(Role.Admin, Role.ParkingOwner, Role.Customer, Role.ParkingManager)]
        public async Task<IActionResult> GetAllAvaiable()
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
                ImageUrls = p.Images.Select(i => i.URL).FirstOrDefault(),

            }).Where(p => p.Status == Status.Available));
        }


        [HttpGet("/parking/{id}")]
        [Authorization.Authorize(Role.Admin, Role.ParkingOwner, Role.Customer, Role.ParkingManager)]
        public IActionResult Get(string id)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            var p = _respository.GetAsync(id);
            if (p == null) return NotFound();
            return Ok(new
            {
                ParkingID = p.ID,
                p.ParkingName,
                LAT = p.LAT,
                IsLegal = p.IsLegal,
                p.LON,
                p.Status,
                p.Discription,
                p.AddressDetail,
                ParkingManagers = p.ParkingManagers.Select(
                    pm => new
                    {
                        pm.ID,
                        FullName = pm.LastName + " " + pm.FirstName,
                        PhoneNumber = pm.PhoneNumber,
                        pm.Email,
                        ImageUrl = pm.Image.URL,
                    }
                    ),
                p.Feedbacks,
                Owner = new
                {
                    p.Owner.ID,
                    FullName = p.Owner.LastName + " " + p.Owner.FirstName,
                    PhoneNumber = p.Owner.PhoneNumber,
                    Email = p.Owner.Email,
                    p.Owner.Gender,

                },



                ImageUrls = p.Images.Select(i => i.URL).ToList(),
                PriceDetails = p.Slots.GroupBy(s => s.Price).Select(
                   group => new
                   {
                       Price = group.Key,
                       SlotType = group.FirstOrDefault().TypeOfSlot,
                       NumberOfSlots = group.Count(),
                       NumberOfSlotAvailable = group.Count(s => s.Status == Status.Available)
                   }

                    )


            });
        }


        [HttpGet("/parkings/{name}")]
        [Authorization.Authorize(Role.Admin, Role.ParkingOwner, Role.Customer, Role.ParkingManager)]
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
                ParkingManagers = p.ParkingManagers.Select(
                    pm => new
                    {
                        pm.ID,
                        FullName = pm.LastName + pm.FirstName,
                        PhoneNumber = pm.PhoneNumber,
                        pm.Email,
                        ImageUrl = pm.Image.URL,
                    }
                    ),
                Feedbacks = p.Feedbacks/*.Select(
                    fb => new
                    {
                        fb.ID,
                        fb.Rating,
                        fb.Content,
                        FeebackBy = fb.FeedbackBy.ID.ToString()
                    }
                    ),*/,

                ImageUrls = p.Images.Select(i => i.URL).ToList(),
                Slot = p.Slots.Select(s =>
              new
              {
                  SlotID = s.ID,
                  s.Price,
                  s.TypeOfSlot,
                  s.Status,
                  s.Discription,
                  s.LastModifyAt

              }),
            }));
        }

        [HttpGet("/pending-parkings")]
        [Authorization.Authorize(Role.Admin, Role.ParkingOwner, Role.Customer, Role.ParkingManager)]
        public async Task<IActionResult> GetPendingParkings()
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            var parkings = await _respository.GetListParkingPending();

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
                ParkingManagers = p.ParkingManagers.Select(
                    pm => new
                    {
                        pm.ID,
                        FullName = pm.LastName + " " + pm.FirstName,
                        PhoneNumber = pm.PhoneNumber,
                        pm.Email,
                        ImageUrl = pm.Image.URL,
                    }
                    ),
                Feedbacks = p.Feedbacks,/*.Select(
                    fb => new
                    {
                        fb.ID,
                        fb.Rating,
                        fb.Content,
                        FeebackBy = fb.FeedbackBy.ID.ToString()
                    }
                    ),*/

                ImageUrls = p.Images.Select(i => i.URL).ToList(),
                Slot = p.Slots.Select(s =>
              new
              {
                  SlotID = s.ID,
                  s.Price,
                  s.TypeOfSlot,
                  s.Status,
                  s.Discription,
                  s.LastModifyAt

              }),
            }));
        }


        [HttpGet("/pending-parkings-number")]
        [Authorization.Authorize(Role.Admin, Role.ParkingOwner, Role.Customer, Role.ParkingManager)]
        public async Task<IActionResult> GetPendingParkingsNumber()
        {
            var listParking = await _respository.GetListParkingPending();
            return Ok(listParking.Count);
        }

        [HttpPatch("/aprrove-parking/{parkingId}")]
        [Authorization.Authorize(Role.Admin, Role.ParkingOwner)]
        public async Task<IActionResult> AprovePending(string parkingId)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            if (!ModelState.IsValid) return BadRequest(ModelState);
            _respository.AproveParking(parkingId);
            return Ok("Change status success");
        }

        [HttpPatch("/cancel-parking/{parkingId}")]
        [Authorization.Authorize(Role.Admin, Role.ParkingOwner)]
        public async Task<IActionResult> Cancel(string parkingId)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            if (!ModelState.IsValid) return BadRequest(ModelState);
            _respository.CancelParkingInvalid(parkingId);
            return Ok("Change status success");
        }


        [HttpPost("/parking")]
        [Authorization.Authorize(Role.Admin, Role.ParkingOwner)]
        public IActionResult Add(ParkingModel model)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            if (!ModelState.IsValid) return BadRequest(ModelState);


            _respository.AddAsync(model, mwi.User);
            return Ok("Add Success");
        }

        [HttpPut("/parking/{id}")]
        [Authorization.Authorize(Role.Admin, Role.ParkingOwner)]
        public async Task<IActionResult> Update(string id, ParkingModel model)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            if (!ModelState.IsValid) return BadRequest(ModelState);
            _respository.UpdateAsync(id, model);
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

        [HttpGet("/parking-prices")]

        public async Task<IActionResult> GetParkingsPrice()
        {

            var parkings = await _respository.GetAllAsync();

            return Ok(parkings.Select(p => new
            {
                ParkingID = p.ID,
                PriceDetails = p.Slots.GroupBy(s => s.Price).Select(
                   group => new
                   {
                       Price = group.Key,
                       SlotType = group.FirstOrDefault().TypeOfSlot,
                   }
                    )


            }).ToList());
        }



    }
}
