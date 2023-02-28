using Back_end.Authorization;
using Back_end.Common;
using Back_end.Models;
using Back_end.Models.User;
using Back_end.Respository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Back_end.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SlotController : ControllerBase
    {
        private readonly ISlotRepository _respository;
        private readonly IJwtUtils _jwtUtils;

        public SlotController(ISlotRepository slotRepository, IJwtUtils jwtUtils)
        {
            _respository = slotRepository;
            _jwtUtils = jwtUtils;
        }


        [HttpGet("/slots")]
        [Authorization.Authorize(Role.Admin,Role.ParkingOwner)]
        public async Task<IActionResult> GetAll()
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            var slots = await _respository.GetAllAsync();

            return Ok(slots);
        }

        [HttpPost("/slot")]
        [Authorization.Authorize(Role.Admin, Role.ParkingOwner)]
        public async Task<IActionResult> Add(SlotModel slotModel)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            if (ModelState.IsValid) BadRequest();
            slotModel.LastModifyByID = mwi.User.ID.ToString();
            await _respository.AddAsync(1,slotModel);

            return Ok("Add Success");
        }

    }
}
