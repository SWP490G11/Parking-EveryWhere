using Back_end.Authorization;
using Back_end.Common;
using Back_end.Entities;
using Back_end.Models;
using Back_end.Models.User;
using Back_end.Respository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Back_end.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParkingController : ControllerBase
    {
        private readonly IJwtUtils _jwtUtils;
        private readonly IParkingRespository _respository;

        public ParkingController(IJwtUtils jwtUtils, IParkingRespository respository)
        {
            _jwtUtils = jwtUtils;
            _respository = respository;
        }

        [HttpGet("/parkings-of-owner")]
        [Authorization.Authorize(Role.Admin,Role.ParkingOwner)]
        public async Task<IActionResult> GetParkingsOfOwnerAsync()
        {

            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");

            var user = mwi.User;
            if (user == null) return NotFound();

            var all = await _respository.GetAllAsync();
            var parkings = all.Where(p => p.Owner.ID.ToString().ToLower().Equals(user.ID.ToString().ToLower())).ToList();
           

            return Ok(parkings);
        }

        [HttpGet("/parking-manager-of-parking/{id}")]
        [Authorization.Authorize(Role.Admin, Role.ParkingOwner)]
        public async Task<IActionResult> GetParkingManagerOfParking(string id)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");

            var user = mwi.User;
            if (user == null) return NotFound();

            var parking= await _respository.GetAsync(id);
            

            return Ok(parking.ParkingManagers);
        }

        [HttpGet("/parkings")]
        [Authorization.Authorize(Role.Admin)]
        public async Task<IActionResult> GetAll()
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            var carModels = await _respository.GetAllAsync();

            return Ok(carModels);
        }

        [HttpGet("/parking/{id}")]
        [Authorization.Authorize(Role.Admin)]
        public async Task<IActionResult> Get(string id)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            var carModel = await _respository.GetAsync(id);

            return Ok(carModel);
        }

        [HttpPost("/parking")]
        [Authorization.Authorize(Role.Admin, Role.ParkingOwner)]
        public async Task<IActionResult> Add(ParkingModel model)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            if (!ModelState.IsValid) return BadRequest(ModelState);
            
            await _respository.AddAsync(model,mwi.User);
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
