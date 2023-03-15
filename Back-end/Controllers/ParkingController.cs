using AutoMapper;
using Back_end.Common;
using Back_end.Models;
using Back_end.Models.User;
using Back_end.Respository;
using Microsoft.AspNetCore.Mvc;

namespace Back_end.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParkingController : ControllerBase
    {

        private readonly IParkingRespository _respository;
        private readonly IMapper _mapper;

        public ParkingController(IParkingRespository respository, IMapper mapper)
        {

            _respository = respository;
            _mapper = mapper;
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
        [Authorization.Authorize(Role.Admin)]
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

    }
}
