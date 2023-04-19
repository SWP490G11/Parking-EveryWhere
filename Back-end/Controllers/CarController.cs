using Back_end.Common;
using Back_end.Models.User;
using Back_end.Models;
using Back_end.Respository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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

            return Ok(cars);
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

            }));
        }


        [HttpGet("/cars-of-owner")]
         [Authorization.Authorize(Role.Admin,Role.Customer,Role.ParkingManager,Role.ParkingOwner)]
        public async Task<IActionResult> GetCarsOfOwner()
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");


            return Ok(mwi.User.Cars.Select(c => new{
              c.ID,
              c.CarNumber,
              c.CarModel,
              
            })) ;
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
