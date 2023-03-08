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


        public UserController(IUserRespository userRespository
 , IJwtUtils jwtUtils, IMapper mapper, IImageService imageService

            )
        {
            _userRespository = userRespository;
            _jwtUtils = jwtUtils;
            _mapper = mapper;
            _imageService = imageService;

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
        [Authorization.Authorize(Role.Admin)]
        public async Task<IActionResult> GetUserbyUserName(string username)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            var users = await _userRespository.GetUserByUserNames(username);

            return Ok(users);
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
        [Authorization.Authorize(Role.Admin)]
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
         

            return Ok(mwi.User);
        }




        [HttpPost("[action]")]
        [AllowAnonymous]
        public async Task<IActionResult> Register(UserModel userModel)
        {
            
                if (!ModelState.IsValid) return BadRequest(ModelState);
                if (await _userRespository.UsernameExisted(userModel.UserName)) return BadRequest("Username has existed");
                if (userModel.Role == Role.Admin || userModel.Role == Role.ParkingManager) return BadRequest("You not have permission for " +
                    "registor this role");
                await _userRespository.Register(userModel);
         
            return Ok("Register Success");

        }

        [HttpPost("[action]")]
        [Authorization.Authorize(Role.ParkingOwner)]
        public async Task<IActionResult> RegisterForParkingManager(UserModel userModel)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (await _userRespository.UsernameExisted(userModel.UserName)) return BadRequest("Username has existed");
            if (userModel.Role == Role.Admin || userModel.Role == Role.ParkingManager) return BadRequest("You not have permission for " +
                "registor this role");
            await _userRespository.Register(userModel);
            return Ok("Register Success");
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
        public async Task<IActionResult> Update(string id, UserModel userModel)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            if (!ModelState.IsValid) return BadRequest(ModelState);
            await _userRespository.Update(id, userModel);
            return Ok("Update Success");
        }

        [HttpPut("[action]")]
        [Authorization.Authorize(Role.Admin)]
        public async Task<IActionResult> DisableOrActive(string id)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            if (!ModelState.IsValid) return BadRequest(ModelState);
            await _userRespository.DisableOrActiveUser(id);
            return Ok("Change state success");
        }


        [Authorization.Authorize(Role.Admin, Role.ParkingOwner,Role.Customer,Role.ParkingManager)]
        [HttpPost("[action]")]
        public async Task<IActionResult> UploadImage(IFormFile file)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");

            var result=  await  _imageService.UploadImageAsync(file);
            var user = mwi.User;

            var allowedExtensions = new[] { ".jpg", ".jpeg", ".png", ".gif" };
            var fileExtension = Path.GetExtension(file.FileName);

            if (!allowedExtensions.Contains(fileExtension.ToLower()))
            {
                // File uploaded is not an image file.
                // Handle the error as desired (e.g. return an error message).
                return BadRequest("Choice wrong fomart file");
            }

            var image = new Image()
            {
                PublicID = result.PublicId,
                URL = result.SecureUri.AbsoluteUri
            };

            if (user.Images.Count == 0) image.IsMain = true;

            user.Images.Add(image);
           
            if (result.Error != null) return BadRequest(result.Error.Message);

            return Ok(_mapper.Map<ImageModel>(image));
        }

    }
}
