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
    public class CarModelController : ControllerBase
    {
        private readonly ICRUDSRespository<CarModel, CarModelx2> _respository;
        private readonly IJwtUtils _jwtUtils;

        public CarModelController(ICRUDSRespository<CarModel, CarModelx2> respository, IJwtUtils jwtUtils)
        {
            _respository = respository;
            _jwtUtils = jwtUtils;
        }

        [HttpGet("[action]")]
        [Authorization.Authorize(Role.Admin)]
        public async Task<IActionResult> GetAll()
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            var carModels = await _respository.GetAllAsync();

            return Ok(carModels);
        }

        [HttpGet("[action]")]
        [Authorization.Authorize(Role.Admin)]
        public async Task<IActionResult> Get(string id)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            var carModel = await _respository.GetAsync(id);

            return Ok(carModel);
        }

        [HttpPost("[action]")]
        [Authorization.Authorize(Role.Admin)]
        public async Task<IActionResult> Add( CarModelx2 carModel)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            if (!ModelState.IsValid) return BadRequest(ModelState);
            await _respository.AddAsync( carModel);
            return Ok("Update Success");
        }

        [HttpPut("[action]")]
        [Authorization.Authorize(Role.Admin)]
        public async Task<IActionResult> Update(string id, CarModelx2 carModel)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            if (!ModelState.IsValid) return BadRequest(ModelState);
            await _respository.UpdateAsync(id, carModel);
            return Ok("Update Success");
        }


        [HttpDelete("[action]")]
        [Authorization.Authorize(Role.Admin)]
        public async Task<IActionResult> Delete(string id)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            if (!ModelState.IsValid) return BadRequest(ModelState);
            await _respository.DeleteAsync(id);
            return Ok("Update Success");
        }
    }
}
