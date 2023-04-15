using Back_end.Common;
using Back_end.Models.User;
using Back_end.Models;
using Back_end.Respository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;
using Back_end.Entities;

namespace Back_end.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParkingDetailController : ControllerBase
    {
        private readonly IParkingDetailRepository _repository;

        public ParkingDetailController(IParkingDetailRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("/parkingdetails")]
        [Authorization.Authorize(Role.Admin)]
        public async Task<IActionResult> GetAll()
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            var parkingdetails = await _repository.GetAllAsync();

            return Ok(parkingdetails.Select(pd=>new
            {
                pd.ID,Car = new {pd.Car.ID,pd.Car.CarNumber,CarOnerID = pd.Car.CarOwner.ID, }
                ,Slot =new {pd.Slot.ID,pd.Slot.TypeOfSlot},
                pd.ParkingDate,pd.PickUpDate,pd.TotalPrice,
            }));
        }

     

        [HttpGet("/parkingdetails/{id}/GetDetail")]

        [Authorization.Authorize(Role.Admin, Role.Customer, Role.ParkingOwner, Role.ParkingManager)]
        public async Task<IActionResult> Get(string id)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            var pd = await _repository.GetAsync(id);

            return Ok(new
            {
                pd.ID,
                Car = new { pd.Car.ID, pd.Car.CarNumber, CarOnerID = pd.Car.CarOwner.ID, }
                ,
                Slot = new { pd.Slot.ID, pd.Slot.TypeOfSlot, pd.Slot.Price },
                pd.ParkingDate,
                pd.PickUpDate,
                pd.TotalPrice,
            });
        }


        [HttpGet("/parkingdetails/{carID}/GetParkingDetailsByCar")]

        [Authorization.Authorize(Role.Admin, Role.Customer, Role.ParkingOwner, Role.ParkingManager)]
        public async Task<IActionResult> GetParkingDetailsByCar(string carID)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            var parkingdetails = await _repository.GetParkingDetailsByCar(carID);


            return Ok(parkingdetails.Select(pd => new
            {
                pd.ID,
                Car = new { pd.Car.ID, pd.Car.CarNumber, CarOnerID = pd.Car.CarOwner.ID, }
                ,
                Slot = new { pd.Slot.ID,  pd.Slot.TypeOfSlot,pd.Slot.Price },
                  pd.ParkingDate,
                pd.PickUpDate,
                pd.TotalPrice,
            }));
        }

        [HttpGet("/parkingdetails/{SlotID}/GetParkingDetailsBySlot")]

        [Authorization.Authorize(Role.Admin, Role.Customer, Role.ParkingOwner, Role.ParkingManager)]
        public async Task<IActionResult> GetParkingDetailsBySlot(string SlotID)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            var parkingdetails = await _repository.GetParkingDetailsBySlot(SlotID);

            return Ok(parkingdetails.Select(pd => new
            {
                pd.ID,
                Car = new { pd.Car.ID, pd.Car.CarNumber, CarOnerID = pd.Car.CarOwner.ID, }
                ,
                Slot = new { pd.Slot.ID, pd.Slot.TypeOfSlot,pd.Slot.Price },
                pd.ParkingDate,
                pd.PickUpDate,
                pd.TotalPrice,
              
            }));
        }

       

        [HttpPost("/parkingdetail")]

        [Authorization.Authorize(Role.ParkingManager,Role.Admin,Role.ParkingOwner)]
        public async Task<IActionResult> Add(ParkingDetailModel parkingdetail)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            if (!ModelState.IsValid) return BadRequest(ModelState);
            await _repository.AddAsync(parkingdetail);
            return Ok("Add Success");
        }

        [HttpPut("/parkingdetail/{id}")]

        [Authorization.Authorize(Role.ParkingManager,Role.Admin)]
        public async Task<IActionResult> Update(string id, ParkingDetailModel parkingdetail)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            if (!ModelState.IsValid) return BadRequest(ModelState);
            await _repository.UpdateAsync(id, parkingdetail);
            return Ok("Update Success");
        }

        [HttpPatch("/parkingdetail/{id}/CarOut")]

        [Authorization.Authorize(Role.ParkingManager, Role.Admin)]
        public async Task<IActionResult> CarOut(string id)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            if (!ModelState.IsValid) return BadRequest(ModelState);
           await _repository.CarOut(id);
            return Ok("Car out of the slot");
        }


        [HttpDelete("/parkingdetail/{id}")]

        [Authorization.Authorize(Role.ParkingManager,Role.Admin)]
        public async Task<IActionResult> Delete(string id)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            if (!ModelState.IsValid) return BadRequest(ModelState);
            await _repository.DeleteAsync(id);
            return Ok("Deletes Success");
        }
    }
}
