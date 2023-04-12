using Back_end.Authorization;
using Back_end.Common;
using Back_end.Entities;
using Back_end.Helper;
using Back_end.Models;
using Back_end.Models.User;
using Back_end.Respository;
using Back_end.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Back_end.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembershipPackageController : ControllerBase
    {
        private readonly ParkingDbContext _dbContext;
        private readonly IMembershipPackageRespository _respository;
        private readonly IVnPayService _vnPayService;
        public MembershipPackageController(ParkingDbContext dbContext, IMembershipPackageRespository respository
            ,IVnPayService vnPayService
            )
        {
            _dbContext = dbContext;
            _respository = respository;
            _vnPayService = vnPayService;
        }

        [HttpGet("[action]")]
        [Authorization.Authorize(Role.Admin,Role.ParkingManager)]
        public async Task<IActionResult> GetAll()
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            var membershipPagekages = await _respository.GetAllAsync();

            return Ok(membershipPagekages.Select(m=> new
            {
                m.ID,
                m.Name,
                m.Discription,
                m.Price,
                m.Months,
                Subcribers = m.SubcribeBy.Select(s=> new {
                 s.ID,
                 s.UserName,
                 FullName = s.LastName+s.FirstName,
                 
                })
            }));
        }

        [HttpGet("[action]")]
        [Authorization.Authorize(Role.Admin, Role.ParkingManager)]
        public async Task<IActionResult> Get(string id)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            var m = await _respository.GetAsync(id);

            return Ok(new
            {
                m.ID,
                m.Name,
                m.Discription,
                m.Price,
                m.Months,
                Subcribers = m.SubcribeBy.Select(s => new {
                    s.ID,
                    s.UserName,
                    FullName = s.LastName + s.FirstName,

                })
            });
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

        [HttpPost("[action]")]
      
        public async Task<IActionResult> SubcribeMembership(string id)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var membershipPackage =await _respository.GetAsync(id);
            var url = _vnPayService.CreatePaymentUrl(membershipPackage,mwi.User,HttpContext);
            return Redirect(url);
        }

        [HttpGet("[action]")]
        [AllowAnonymous] 
        public IActionResult PaymentCallback()
        {
           
            var response = _vnPayService.PaymentExecute(Request.Query);
            var transactor = _dbContext.Users.FirstOrDefault(x=>x.ID.ToString().ToLower().Equals(response.OrderDescription));
            response.Transactor = transactor;

            _dbContext.Transactions.Add(response);
            _dbContext.SaveChanges();

            return Ok(response);
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
