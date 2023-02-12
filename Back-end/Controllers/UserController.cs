using Back_end.Authorization;
using Back_end.Common;
using Back_end.Entities;
using Back_end.Helper;
using Back_end.Models.User;
using Back_end.Respository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AuthorizeAttribute = Back_end.Authorization.AuthorizeAttribute;

namespace Back_end.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRespository _userRespository;
        private readonly ParkingDbContext _dbContext;
        private readonly IJwtUtils _jwtUtils;
       public UserController(IUserRespository userRespository, ParkingDbContext dbContext
 , IJwtUtils jwtUtils
            )
        {
            _userRespository = userRespository;
            _dbContext = dbContext;
            _jwtUtils = jwtUtils;
        }

        [AllowAnonymous]
        [HttpPost("[action]")]
        public async Task<IActionResult> Authenticate(AuthenticateRequest model)
        {
            if (!ModelState.IsValid)  return BadRequest(ModelState);
            var response = await _userRespository.Authenticate(model);
            return Ok(response);
        }



        [HttpGet("[action]")]
        [Authorization.Authorize(Role.Admin)]
        public async Task<IActionResult> GetAll()
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            var users = await _userRespository.GetUsers();
           
            return Ok(users);
        }

        [HttpGet("[action]")]
     
        public async Task<IActionResult> Test()
        {
            HttpContext context = HttpContext;
           
            var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
            var encodetoken = _jwtUtils.ValidateJwtToken(token);
           /* var userid = encodetoken.Split(" ")[1];
            var user = await _userRespository.GetUser(userid);*/
            return Ok(encodetoken.Split(" ")[1]);
        }

    }
}
