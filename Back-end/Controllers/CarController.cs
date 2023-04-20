using Back_end.Common;
using Back_end.Models.User;
using Back_end.Models;
using Back_end.Respository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Back_end.Entities;

namespace Back_end.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarRepository _respository;

        public CarController(ICarRepository carRepository)
        {
            _respository = carRepository;
        }

        [HttpGet("/cars")]
        [Authorization.Authorize(Role.Admin,Role.Customer,Role.ParkingManager,Role.ParkingOwner)]
        public async Task<IActionResult> GetAll()
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            var cars = await _respository.GetAllAsync();

            return Ok(cars.Select(c => new {
                c.ID,
                c.CarNumber,
                c.CarModel,
                c.Status,
                CarOwner = new
                {
                    c.CarOwner.ID,
                    c.CarOwner.Email,
                    c.CarOwner.PhoneNumber,
                    FullName = c.CarOwner.LastName + " " + c.CarOwner.FirstName,

                },
                ParkingDetail = c.ParkingDetails.Select(p => new {
                    p.ID,
                    p.ParkingDate,
                    p.PickUpDate,
                    p.TotalPrice,
                    p.Note,
                    Slot = new
                    {
                        p.Slot.ID,
                        p.Slot.TypeOfSlot,
                        p.Slot.Discription,
                    }
                })

            })
     );
        }

        [HttpGet("/cars-available")]
        [Authorization.Authorize(Role.Admin,Role.Customer,Role.ParkingManager,Role.ParkingOwner)]
        public async Task<IActionResult> GetAllAvailable()
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            var cars = await _respository.GetAllAvailable();

            return Ok(cars.Select(c => new {
                c.ID,
                c.CarNumber,
                c.CarModel,
                c.Status,                
                CarOwner = new
                {
                    c.CarOwner.ID,
                    c.CarOwner.Email,
                    c.CarOwner.PhoneNumber,
                    FullName = c.CarOwner.LastName + " " + c.CarOwner.FirstName,

                },
            })
     );
        }
        
        [HttpGet("/cars/{carModelID}")]
        [Authorization.Authorize(Role.Admin,Role.Customer,Role.ParkingManager,Role.ParkingOwner)]
        public async Task<IActionResult> GetCarbyCarModel(string carModelID)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            var cars = await _respository.GetCarByCarModel(carModelID);

            return Ok(cars.Select(c => new {
                c.ID,
                c.CarNumber,
                c.CarModel,
                c.Status,
                CarOwner = new
                {
                    c.CarOwner.ID,
                    c.CarOwner.Email,
                    c.CarOwner.PhoneNumber,
                    FullName = c.CarOwner.LastName + " " + c.CarOwner.FirstName,

                },
                ParkingDetail = c.ParkingDetails.Select(p => new {
                    p.ID,
                    p.ParkingDate,
                    p.PickUpDate,
                    p.TotalPrice,
                    p.Note,
                    Slot = new
                    {
                        p.Slot.ID,p.Slot.TypeOfSlot,p.Slot.Discription,
                    }
                })

            })
     );
        }


        [HttpGet("/cars-of-owner")]
        [Authorization.Authorize(Role.Admin, Role.Customer, Role.ParkingManager, Role.ParkingOwner)]
        public async Task<IActionResult> GetCarsOfOwner()
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");


            return Ok(mwi.User.Cars.Select(c => new {
                c.ID,
                c.CarNumber,
                c.CarModel,
                c.Status,
               
                ParkingDetail = c.ParkingDetails.Select(p => new {
                    p.ID,
                    p.ParkingDate,
                    p.PickUpDate,
                    p.TotalPrice,
                    p.Note,
                    Parking = new
                    {
                        p.Slot.Parking.ID,
                        p.Slot.Parking.ParkingName,
                        p.Slot.Parking.AddressDetail,
                        p.Slot.Parking.Status,
                    },
                    Slot = new
                    {
                        p.Slot.ID,
                        p.Slot.TypeOfSlot,
                        p.Slot.Discription,
                       
                    }


                })

            })
     );
        }


            [HttpGet("/car/{id}")]

         [Authorization.Authorize(Role.Admin,Role.Customer,Role.ParkingManager,Role.ParkingOwner)]
        public async Task<IActionResult> Get(string id)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            var c = await _respository.GetAsync(id);

            return Ok(new
            {
                c.ID,
                c.CarNumber,
                c.CarModel,
                c.Status,

                ParkingDetail = c.ParkingDetails.Select(p => new {
                    p.ID,
                    p.ParkingDate,
                    p.PickUpDate,
                    p.TotalPrice,
                    p.Note,
                    Slot = new
                    {
                        p.Slot.ID,
                        p.Slot.TypeOfSlot,
                        p.Slot.Discription,
                    }
                })

            });
        }

        [HttpPost("/car")]

         [Authorization.Authorize(Role.Admin,Role.Customer,Role.ParkingManager,Role.ParkingOwner)]
        public async Task<IActionResult> Add(CarDTO car)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            if (!ModelState.IsValid) return BadRequest(ModelState);
            await _respository.AddAsync(car,mwi.User);
            return Ok("Add Success");
        }

        [HttpPut("/car/{id}")]

        [Authorization.Authorize(Role.Admin,Role.Customer,Role.ParkingManager,Role.ParkingOwner)]
        public async Task<IActionResult> Update(string id, CarDTO car)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            if (!ModelState.IsValid) return BadRequest(ModelState);
            await _respository.UpdateAsync(id, car);
            return Ok("Update Success");
        }


        [HttpDelete("/car/{id}")]

         [Authorization.Authorize(Role.Admin,Role.Customer,Role.ParkingManager,Role.ParkingOwner)]
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
