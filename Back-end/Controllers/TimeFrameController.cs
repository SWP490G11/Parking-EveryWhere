using AutoMapper;
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
    public class TimeFrameController : ControllerBase
    {
        private readonly IJwtUtils _jwtUtils;
        private readonly ICRUDSRespository<TimeFrame, TimeFrameModel> _respository;
        private readonly IMapper _mapper;

        public TimeFrameController(IJwtUtils jwtUtils, ICRUDSRespository<TimeFrame, TimeFrameModel> respository,
           IMapper mapper
            )
        {
            _jwtUtils = jwtUtils;
            _respository = respository;
            _mapper = mapper;
        }

       
        [HttpGet("/timeframes")]
        [Authorization.Authorize(Role.Admin)]
        public async Task<IActionResult> GetAll()
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            var timeFrames = await _respository.GetAllAsync();

            return Ok(_mapper.Map<ICollection<TimeFrameModel>>(timeFrames));
        }

        [HttpGet("/timeframe/{id}")]
        [Authorization.Authorize(Role.Admin)]
        public async Task<IActionResult> Get(string id)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            var timeFrame = await _respository.GetAsync(id);

            return Ok(_mapper.Map<TimeFrameModel>(timeFrame));
        }

        [HttpPost("/timeframe")]
        [Authorization.Authorize(Role.Admin, Role.ParkingOwner)]
        public async Task<IActionResult> Add(TimeFrameModel model)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            if (!ModelState.IsValid) return BadRequest(ModelState);
            await _respository.AddAsync(model);
            return Ok("Add Success");
        }

        [HttpPut("/timeframe/{id}")]
        [Authorization.Authorize(Role.Admin, Role.ParkingOwner)]
        public async Task<IActionResult> Update(string id, TimeFrameModel model)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            if (!ModelState.IsValid) return BadRequest(ModelState);
            await _respository.UpdateAsync(id, model);
            return Ok("Update Success");
        }


        [HttpDelete("/timeframe/{id}")]
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
