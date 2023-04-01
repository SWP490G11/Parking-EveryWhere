using Back_end.Common;
using Back_end.Models.User;
using Back_end.Models;
using Back_end.Respository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;

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

     

        [HttpGet("/parkingdetail/{id}")]

        [Authorization.Authorize(Role.Admin, Role.Customer, Role.ParkingOwner, Role.ParkingManager)]
        public async Task<IActionResult> Get(string id)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            var parkingdetail = await _repository.GetAsync(id);

            return Ok(parkingdetail);
        }


        [HttpGet("/parkingdetail/{carID}")]

        [Authorization.Authorize(Role.Admin, Role.Customer, Role.ParkingOwner, Role.ParkingManager)]
        public async Task<IActionResult> GetParkingDetailsByCar(string carID)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            var parkingdetail = await _repository.GetParkingDetailsByCar(carID);

            return Ok(parkingdetail);
        }

        [HttpGet("/parkingdetail/{SlotID}")]

        [Authorization.Authorize(Role.Admin, Role.Customer, Role.ParkingOwner, Role.ParkingManager)]
        public async Task<IActionResult> GetParkingDetailsBySlot(string SlotID)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            var parkingdetail = await _repository.GetParkingDetailsBySlot(SlotID);

            return Ok(parkingdetail);
        }

        [HttpGet("/parkingdetail/{timeframeID}")]

        [Authorization.Authorize(Role.Admin, Role.Customer, Role.ParkingOwner, Role.ParkingManager)]
        public async Task<IActionResult> GetParkingDetailsByTimeFrame(string timeframeID)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            var parkingdetail = await _repository.GetParkingDetailsByTimeFrame(timeframeID);

            return Ok(parkingdetail);
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
