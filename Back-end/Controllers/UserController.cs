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
        private readonly IJwtUtils _jwtUtils;
       public UserController(IUserRespository userRespository
 , IJwtUtils jwtUtils
            )
        {
            _userRespository = userRespository;
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

       

        [HttpPost("[action]")]
        [AllowAnonymous]
        public async Task<IActionResult> Register(UserModel userModel)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (await _userRespository.UsernameExisted(userModel.UserName)) return BadRequest("Username has existed") ;
            await _userRespository.Register(userModel);
            return Ok("Register Success");
        }


        [HttpPost("[action]")]
        [AllowAnonymous]
        public async Task<IActionResult> Update(string id,UserModel userModel)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
           await _userRespository.Update(id,userModel);
            return Ok("Register Success");
        }

    }
}
