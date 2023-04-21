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

            return Ok(parkingdetails);
        }

     

        [HttpGet("/parkingdetails/{id}/GetDetail")]

        [Authorization.Authorize(Role.Admin, Role.Customer, Role.ParkingOwner, Role.ParkingManager)]
        public async Task<IActionResult> Get(string id)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            var pd = await _repository.GetAsync(id);

            return Ok(pd);
        }


        [HttpGet("/parkingdetails/{carID}/GetParkingDetailsByCar")]

        [Authorization.Authorize(Role.Admin, Role.Customer, Role.ParkingOwner, Role.ParkingManager)]
        public async Task<IActionResult> GetParkingDetailsByCar(string carID)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            var parkingdetails = await _repository.GetParkingDetailsByCar(carID);


            return Ok(parkingdetails);
        }

        [HttpGet("/parkingdetails/{SlotID}/GetParkingDetailsBySlot")]

        [Authorization.Authorize(Role.Admin, Role.Customer, Role.ParkingOwner, Role.ParkingManager)]
        public async Task<IActionResult> GetParkingDetailsBySlot(string SlotID)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            var parkingdetails = await _repository.GetParkingDetailsBySlot(SlotID);

            return Ok(parkingdetails);
        }


        [HttpGet("/parkingdetails/{parkingID}/GetParkingDetailsByParking")]

        [Authorization.Authorize(Role.Admin, Role.Customer, Role.ParkingOwner, Role.ParkingManager)]
        public IActionResult GetAllParkingDetailsOfParking(string parkingID)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            var parkingdetails = _repository.GetAllParkingDetailsOfParking(parkingID);

            return Ok(parkingdetails.Select(p=>
            new
            {
                p.ID,
                p.ParkingDate,
                p.PickUpDate,
                p.TotalPrice,
                Car = new
                {
                    p.Car.ID, p.Car.CarModel,
                    p.Car.CarNumber, p.Car.Status,
                    Owner = new
                    {
                        p.Car.CarOwner.ID, FullName = p.Car.CarOwner.LastName + " " + p.Car.CarOwner.FirstName, p.Car.CarOwner.PhoneNumber, p.Car.CarOwner.Email, p.Car.CarOwner.DateOfBirth, p.Car.CarOwner.Gender,
                    }
                }
                ,
                Slot = new
                {
                    p.Slot.ID,
                    p.Slot.Price,
                    p.Slot.Status,
                    p.Slot.Discription,
                    p.Slot.TypeOfSlot,

                }

                , Parking = new
                {
                    p.Slot.Parking.ID,p.Slot.Parking.ParkingName,p.Slot.Parking.Discription,p.Slot.Parking.IsLegal,p.Slot.Parking.Status, 
                }

               
               

            }
              
            ));;
        }


        [HttpGet("/parkingdetails/all-parking-of-owner")]

        [Authorization.Authorize(Role.Admin, Role.Customer, Role.ParkingOwner, Role.ParkingManager)]
        public IActionResult GetAllParkingDetailsOfOwner()
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            

            return Ok(mwi.User.Parkings.SelectMany(p=>p.Slots).SelectMany(s=>s.ParkingDetail));
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

        [Authorization.Authorize(Role.Admin, Role.ParkingOwner, Role.ParkingManager)]
        public async Task<IActionResult> CarOut(string id)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            if (!ModelState.IsValid) return BadRequest(ModelState);
         var parkingdetail =  await _repository.CarOut(id);
            return Ok(parkingdetail);
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
