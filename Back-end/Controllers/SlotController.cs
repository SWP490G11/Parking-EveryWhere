using AutoMapper;
using Back_end.Authorization;
using Back_end.Common;
using Back_end.Entities;
using Back_end.Helper;
using Back_end.Models;
using Back_end.Models.User;
using Back_end.Respository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;

namespace Back_end.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SlotController : ControllerBase
    {
        private readonly ISlotRepository _respository;
        private readonly IParkingRespository _parkingRespository;
        private readonly IMapper _mapper;
        private readonly ParkingDbContext _dbContext;

        public SlotController(ISlotRepository slotRepository, IParkingRespository jwtUtils
            , IMapper mapper, ParkingDbContext dbContext
            )
        {
            _respository = slotRepository;
            _parkingRespository = jwtUtils;
            _mapper=mapper;
            _dbContext=dbContext;
            
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
               s.TypeOfSlot,
               ParkingID = s.Parking.ID,
               s.Discription,
               ParkingDetail = s.ParkingDetail,
               s.Status,
               s.LastModifyAt,
              LastModifyBy= s.LastModifyBy.ID,
            }));
        }


        [HttpGet("/available-slots")]
        [Authorization.Authorize(Role.Admin)]
        public IActionResult GetAvailableSlots()
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            var slots =  _respository.GetListSlotAvailable();

            return Ok(slots.Select(s =>
           new {
               SlotID = s.ID,
               s.Price,
               s.TypeOfSlot,
               ParkingID = s.Parking.ID,
               s.Discription,
               ParkingDetail = s.ParkingDetail,
               s.Status,
               s.LastModifyAt,
               LastModifyBy = s.LastModifyBy.ID,
           }));
        }


        [HttpGet("/parking-slots")]
        [Authorization.Authorize(Role.Admin)]
        public  IActionResult GetParkingSlots()
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            var slots =  _respository.GetListSlotParking();

            return Ok(slots.Select(s =>
           new {
               SlotID = s.ID,
               s.Price,
               s.TypeOfSlot,
               ParkingID = s.Parking.ID,
               s.Discription,
               ParkingDetail = s.ParkingDetail,
               s.Status,
               s.LastModifyAt,
               LastModifyBy = s.LastModifyBy.ID,
           }));
        }

        [HttpGet("/slots/{parkingID}")]
        [Authorization.Authorize(Role.Admin,Role.ParkingOwner,Role.ParkingManager)]
        public async Task<IActionResult> GetSlotOfParking(string parkingID)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            var slots = await _respository.GetSlotByParkingAsync(parkingID);

            return Ok(slots);
        }


        [HttpGet("/group-of-slots/{parkingID}")]
        [Authorization.Authorize(Role.Admin)]
        public async Task<IActionResult> GetGroupOfSlots(string parkingID)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");

            var slots = await _respository.GetSlotByParkingAsync(parkingID);
            return Ok( slots.GroupBy(s => s.TypeOfSlot).Select(
                   group => new
                   {
                       TypeOfSlot = group.Key,
                      
                       Price = group.FirstOrDefault().Price,
                   }
                    ));
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


        [HttpPut("/slot/{id}")]

        [Authorization.Authorize(Role.Admin)]
        public async Task<IActionResult> Update(string id, UpdatedSlotModel slotModel)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            if (!ModelState.IsValid) return BadRequest(ModelState);
            await _respository.UpdateAsync(id, slotModel);
            return Ok("Update Success");
        }


        [HttpPatch("/slot/update-range-price")]

        [Authorization.Authorize(Role.Admin)]
        public IActionResult UpdatePrice(string parkingID,TypeOfSlot tos,double updatedPrice)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var parking = _parkingRespository.GetAsync(parkingID);
            var slots = parking.Slots==null ? new List<Slot>() : parking.Slots.Where(s=>s.TypeOfSlot==tos);

            foreach (var slot in slots)
            {
                slot.Price = updatedPrice;
            }

            _dbContext.Slots.UpdateRange(slots);
            _dbContext.SaveChanges();

            return Ok("Update Success");
        }

        [HttpDelete("/slot/{id}")]
     
        [Authorization.Authorize(Role.Admin)]
        public async Task<IActionResult> Delete(string id)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            if (!ModelState.IsValid) return BadRequest(ModelState);
            await _respository.DeleteAsync(id);
            return Ok("Deletes Success");
        }


        [HttpDelete("/slotModel/{tos}")]

        [Authorization.Authorize(Role.Admin)]
        public IActionResult DeleteRange(string parkingID, TypeOfSlot tos)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var parking = _parkingRespository.GetAsync(parkingID);
            var slots = parking.Slots == null ? new List<Slot>() : parking.Slots.Where(s => s.TypeOfSlot == tos);

            _dbContext.Slots.RemoveRange(slots);
            _dbContext.SaveChanges();
            return Ok("Deletes Success");
        }

    }



}
