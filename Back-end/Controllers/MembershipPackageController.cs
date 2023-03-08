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
    public class MembershipPackageController : ControllerBase
    {
        private readonly IJwtUtils _jwtUtils;
        private readonly ICRUDSRespository<MembershipPackage, MembershipPackageModel> _respository;

        public MembershipPackageController(IJwtUtils jwtUtils, ICRUDSRespository<MembershipPackage, MembershipPackageModel> respository)
        {
            _jwtUtils = jwtUtils;
            _respository = respository;
        }

        [HttpGet("[action]")]
        [Authorization.Authorize(Role.Admin)]
        public async Task<IActionResult> GetAll()
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            var membershipPagekages = await _respository.GetAllAsync();

            return Ok(membershipPagekages);
        }

        [HttpGet("[action]")]
        [Authorization.Authorize(Role.Admin)]
        public async Task<IActionResult> Get(string id)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            var membershipPagekage = await _respository.GetAsync(id);

            return Ok(membershipPagekage);
        }

        [HttpPost("[action]")]
        [Authorization.Authorize(Role.Admin)]
        public async Task<IActionResult> Add(MembershipPackageModel membershipPagekage)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            if (!ModelState.IsValid) return BadRequest(ModelState);
            await _respository.AddAsync(membershipPagekage);
            return Ok("Add Success");
        }

        [HttpPut("[action]")]
        [Authorization.Authorize(Role.Admin)]
        public async Task<IActionResult> Update(string id, MembershipPackageModel membershipPagekage)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            if (!ModelState.IsValid) return BadRequest(ModelState);
            await _respository.UpdateAsync(id, membershipPagekage);
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
            return Ok("Deletes Success");
        }

    }
}
