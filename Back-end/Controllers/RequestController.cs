using Back_end.Common;
using Back_end.Models;
using Back_end.Models.User;
using Back_end.Respository;
using Microsoft.AspNetCore.Mvc;

namespace Back_end.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestController : ControllerBase
    {
        private readonly IRequestRepository _repository;

        public RequestController(IRequestRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("/requests")]
        [Authorization.Authorize(Role.Admin)]
        public async Task<IActionResult> GetAll()
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            var requests = await _repository.GetAllAsync();

            return Ok(requests.Select(r =>
          new {
              r.ID,
              r.Status,
              RequestbyID = r.Requestby.ID.ToString(),
              r.RequestAt
          }
            ));
        }


        [HttpGet("/request/{id}")]

        [Authorization.Authorize(Role.Admin, Role.Customer, Role.ParkingOwner, Role.ParkingManager)]
        public async Task<IActionResult> Get(string id)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            var r = await _repository.GetAsync(id);

            return Ok(new
            {
                r.ID,
                r.Note,
                r.Status,
                ParkingId = r.Parking,
                r.RequestAt,
            });
        }

        [HttpGet("/request/{parkingid}")]

        [Authorization.Authorize(Role.Admin, Role.Customer, Role.ParkingOwner, Role.ParkingManager)]
        public async Task<IActionResult> GetListRequestOfParking(string parkingid)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            var requests = await _repository.GetRequestToParking(parkingid);

            return Ok(requests.Select(r=>
          new  {
              r.ID,
              r.Note,
              r.Status,
              ParkingId = r.Parking,
              r.RequestAt,
          } 
            ));
        }

        [HttpGet("/pending-request/{parkingid}")]

        [Authorization.Authorize(Role.Admin, Role.Customer, Role.ParkingOwner, Role.ParkingManager)]
        public async Task<IActionResult> GetListRequestPendingOfParking(string parkingid)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            var requests = await _repository.GetRequestToParking(parkingid);

            return Ok(requests.Select(r =>
          new {
              r.ID,
              r.Note,
              r.Status,
              ParkingId = r.Parking,
              r.RequestAt,
          }
            ));
        }


        [HttpGet("/pending-request-of-all-parkings-of-owner")]

        [Authorization.Authorize(Role.Admin, Role.Customer, Role.ParkingOwner, Role.ParkingManager)]
        public async Task<IActionResult> GetListRequestPendingToTheAllParkingsOfOwner()
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            var requests = mwi.User.Parkings.SelectMany(p=>p.Requests).Where(r=>r.Status ==Status.Pending).ToList();

            return Ok(requests.Select(r =>
          new {
              r.ID,
              r.Note,
              r.Status,
              ParkingId = r.Parking,
              r.RequestAt,
          }
            ));
        }


        [HttpGet("/pending-request-number/{parkingid}")]

        [Authorization.Authorize(Role.Admin, Role.Customer, Role.ParkingOwner, Role.ParkingManager)]
        public async Task<IActionResult> GetListRequestPendingOfParkingNumber(string parkingid)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            var requests = await _repository.GetRequestToParking(parkingid);

            return Ok(requests.Count);
        }

        [HttpGet("/request/myRequest")]

        [Authorization.Authorize(Role.Customer,Role.Admin,Role.ParkingManager,Role.ParkingOwner)]
        public async Task<IActionResult> GetMyRequest()
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            

            return Ok(mwi.User.Requests.Select(r=> new
            {
                r.ID,r.Note,r.Status,ParkingId =r.Parking,r.RequestAt,
            }));
        }

        [HttpPost("/request")]

        [Authorization.Authorize(Role.Customer, Role.Admin, Role.ParkingManager, Role.ParkingOwner)]
        public async Task<IActionResult> Add(RequestModel request)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            if (!ModelState.IsValid) return BadRequest(ModelState);
            await _repository.AddAsync(request, mwi.User);
            return Ok("Add Success");
        }

        [HttpPut("/request/{id}")]

        [Authorization.Authorize(Role.Customer, Role.Admin, Role.ParkingManager, Role.ParkingOwner)]
        public async Task<IActionResult> Update(string id, UpdateRequestModel request)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            if (!ModelState.IsValid) return BadRequest(ModelState);
            await _repository.UpdateAsync(id, request);
            return Ok("Update Success");
        }


        [HttpPatch("/request/cancel-request/{id}")]

        [Authorization.Authorize(Role.Customer, Role.Admin, Role.ParkingManager, Role.ParkingOwner)]
        public async Task<IActionResult> CancelRequest(string id)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            if (!ModelState.IsValid) return BadRequest(ModelState);
            await _repository.CancelRequestAsync(id);
            return Ok("Update Success");
        }


        [HttpPatch("/request/aprove-request/{id}")]

        [Authorization.Authorize(Role.Customer, Role.Admin, Role.ParkingManager, Role.ParkingOwner)]
        public async Task<IActionResult> AproveRequest(string id)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            if (!ModelState.IsValid) return BadRequest(ModelState);
            await _repository.CancelRequestAsync(id);
            return Ok("Update Success");
        }


        [HttpDelete("/request/{id}")]

        [Authorization.Authorize(Role.Customer, Role.Admin, Role.ParkingManager, Role.ParkingOwner)]
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
