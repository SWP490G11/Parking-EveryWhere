using AutoMapper;
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
        private readonly IMapper _mapper;

        public SlotController(ISlotRepository slotRepository, IJwtUtils jwtUtils
            , IMapper mapper
            )
        {
            _respository = slotRepository;
            _jwtUtils = jwtUtils;
            _mapper=mapper;
            
        }


        [HttpGet("/slots")]
        [Authorization.Authorize(Role.Admin)]
        public async Task<IActionResult> GetAll()
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            var slots = await _respository.GetAllAsync();

            return Ok(slots.Select(s=>
           new {
               SlotID= s.ID,
               s.Price,
               CarModelID= s.CarModel.ID,
               ParkingID = s.Parking.ID,
               s.Discription,
               ParkingDetail = s.ParkingDetail.Select(pd=> pd.ID.ToString() ).ToList(),
               s.Status,
               s.LastModifyAt,
              LastModifyBy= s.LastModifyBy.ID,
            }));
        }

        [HttpGet("/slots/{parkingID}")]
        [Authorization.Authorize(Role.Admin)]
        public async Task<IActionResult> GetSlotOfParking(string parkingID)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            var slots = await _respository.GetSlotByParkingAsync(parkingID);

            return Ok(slots.Select(s =>
           new {
               SlotID = s.ID,
               s.Price,
               CarModelID = s.CarModel.ID,
               ParkingID = s.Parking.ID,
               s.Discription,
               ParkingDetail = s.ParkingDetail.Select(pd => pd.ID.ToString()).ToList(),
               s.Status,
               s.LastModifyAt,
               LastModifyBy = s.LastModifyBy.ID,
           }));
        }

        [HttpPost("/slot")]
        [Authorization.Authorize(Role.Admin, Role.ParkingOwner)]
        public async Task<IActionResult> Add(uint quantity,SlotModel slotModel)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            if (ModelState.IsValid) BadRequest();
            slotModel.LastModifyByID = mwi.User.ID.ToString();
            await _respository.AddAsync(quantity,slotModel);

            return Ok("Add Success");
        }

        [HttpPut("/slotModel/{id}")]
        [ValidateAntiForgeryToken]
        [Authorization.Authorize(Role.Admin)]
        public async Task<IActionResult> Update(string id, SlotModel slotModel)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            if (!ModelState.IsValid) return BadRequest(ModelState);
            await _respository.UpdateAsync(id, slotModel);
            return Ok("Update Success");
        }


        [HttpDelete("/slotModel/{id}")]
        [ValidateAntiForgeryToken]
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
