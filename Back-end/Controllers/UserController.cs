using AutoMapper;
using Back_end.Authorization;
using Back_end.Common;
using Back_end.Entities;
using Back_end.Helper;
using Back_end.Models;
using Back_end.Models.User;
using Back_end.Respository;
using Back_end.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Packaging;
using AuthorizeAttribute = Back_end.Authorization.AuthorizeAttribute;

namespace Back_end.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRespository _userRespository;
        private readonly IJwtUtils _jwtUtils;
        private readonly IMapper _mapper;
        private readonly IImageService _imageService;
        private readonly ParkingDbContext _dbContext;
        private readonly IEmailSender _emailSender;

        public UserController(IUserRespository userRespository
 , IJwtUtils jwtUtils, IMapper mapper, IImageService imageService
, ParkingDbContext dbContext, IEmailSender emailSender
            )
        {
            _userRespository = userRespository;
            _jwtUtils = jwtUtils;
            _mapper = mapper;
            _imageService = imageService;
            _dbContext = dbContext;
            _emailSender = emailSender;
        }

        [AllowAnonymous]
        [HttpPost("[action]")]
        public async Task<IActionResult> Authenticate(AuthenticateRequest model)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
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
        [AllowAnonymous]
        public async Task<IActionResult> GetUserbyUserName(string username)
        {
           
            var u = await _userRespository.GetUserByUserNames(username);
            if (u == null) return NotFound("Not Found this user");
            return Ok(
               u
                );
        }

        [HttpGet("[action]")]
        [Authorization.Authorize(Role.Admin)]
        public async Task<IActionResult> Paginate(int pageNo = 1, int pageSize = 5)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");

            if (pageSize <= 0) pageSize = 1;

            var users = await _userRespository.Paginate(pageNo, pageSize);

            return Ok(users);
        }

        [HttpGet("[action]")]
        [Authorization.Authorize(Role.Admin,Role.Customer,Role.ParkingManager,Role.ParkingOwner)]
        public async Task<IActionResult> GetUser(string id)
        {
            
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            var users = await _userRespository.GetUser(id);

            return Ok(users);
        }


        [HttpGet("[action]")]
        [Authorization.Authorize(Role.Admin,Role.Customer,Role.ParkingOwner,Role.ParkingManager)]
        public async Task<IActionResult> GetProfile()
        {

            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            var u = mwi.User;

            return Ok(/*new
            {
                u.ID,
                u.Gender,
                u.IsDisable,
                u.UserName,
                u.DateOfBirth,
                u.Email,
                u.PhoneNumber,
                u.FirstName,
                u.LastName,
                PakingID = u.Parking.ID,
                u.CitizenID,
                u.Image,
                u.Role,
                Parkings = u.Parkings.Select(p=>new
                {
                    p.ID,p.ParkingName,p.IsLegal,p.Status
                })
            }*/
                u
                );
        }




        [HttpPost("[action]")]
        [AllowAnonymous]
        public  IActionResult Register(UserModel userModel)
        {
            

            if (!ModelState.IsValid) return BadRequest(ModelState);
            if ( _userRespository.UsernameExisted(userModel.UserName)) return BadRequest("Username has existed");
                 _userRespository.Register(userModel);
         
            return Ok(userModel);

        }

        

        [HttpPost("[action]")]
        [Authorization.Authorize(Role.ParkingOwner,Role.Admin)]
        public async Task<IActionResult> RegisterForParkingManager(PMModel userModel)
        {

            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");

            if (!ModelState.IsValid) return BadRequest(ModelState);
            /*if (mwi.User.Role!=Role.ParkingOwner) return BadRequest("You not have permission for " +
                "registor this role");*/
         var pm=   await _userRespository.RegisterForParkingManager(userModel);
            return Ok(pm);
        }

        [HttpPut("[action]")]

        public async Task<IActionResult> ChangePassword(string id, ChangePasswordModel userModel)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            if (!ModelState.IsValid) return BadRequest(ModelState);
            await _userRespository.ChangePassword(id, userModel);
            return Ok("ChangePassword Success");
        }

        [HttpPut("[action]")]
        [Authorization.Authorize(Role.Admin, Role.Customer, Role.ParkingOwner)]
        public async Task<IActionResult> Update(string id, UpdateModel userModel)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            if (!ModelState.IsValid) return BadRequest(ModelState);
            await _userRespository.Update(id, userModel);
            return Ok("Update Success");
        }

        [HttpPatch("[action]")]
        [Authorization.Authorize(Role.Admin,Role.ParkingOwner)]
        public async Task<IActionResult> DisableOrActive(string id)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            if (!ModelState.IsValid) return BadRequest(ModelState);
            await _userRespository.DisableOrActiveUser(id);
            return Ok("Change state success");
        }

        [HttpPatch("[action]")]
        [AllowAnonymous]
        public async Task<IActionResult> ResetPassword(string username)
        {
           
            if (!ModelState.IsValid) return BadRequest(ModelState);
            await _userRespository.ResetPassword(username);
            return Ok("send mail thanh cong");
        }

    }
}
