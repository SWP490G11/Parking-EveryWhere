﻿using Back_end.Common;
using Back_end.Models.User;
using Back_end.Models;
using Back_end.Respository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;

namespace Back_end.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedbackController : ControllerBase
    {
        private readonly IFeedBackReposiotory _reposiotory;

        public FeedbackController(IFeedBackReposiotory feedBackReposiotory)
        {
            _reposiotory = feedBackReposiotory;
        }

        [HttpGet("/feedbacks")]
        [Authorization.Authorize(Role.Admin, Role.Customer, Role.ParkingManager, Role.ParkingOwner)]
        public async Task<IActionResult> GetAll()
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            var feedbacks = await  _reposiotory.GetAllFeedbacksAsync();

            return Ok(feedbacks.Select(fb =>
                 new
                 {
                     fb.ID,
                     fb.Rating,
                     fb.Content,
                     ParkingID= fb.Parking.ID.ToString(),
                     Images = fb.Images.Select(i => i.URL),
                     Feedbackby = new
                     {
                         fb.FeedbackBy.ID,fb.FeedbackBy.UserName
                     },
                 }
            ));
        }



        [HttpGet("/feedbacks-of-parking/{parkingID}")]
        [Authorization.Authorize(Role.Admin, Role.Customer, Role.ParkingManager, Role.ParkingOwner)]
        public IActionResult getFeedbackOfParking(string parkingID)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            var feedbacks =  _reposiotory.GetFeedbacksOfParking(parkingID); 

            return Ok(feedbacks.Select(fb =>
                 new
                 {
                     fb.ID,
                     fb.Rating,
                     fb.Content,
                     ParkingID = fb.Parking.ID.ToString(),
                     Images = fb.Images.Select(i => i.URL),
                     Feedbackby = new
                     {
                         fb.FeedbackBy.ID,
                         fb.FeedbackBy.UserName
                     },
                 }
            ));
        }


        [HttpGet("/feedback/{id}")]

        [Authorization.Authorize(Role.Admin, Role.Customer, Role.ParkingManager, Role.ParkingOwner)]
        public async Task<IActionResult> Get(string id)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            var feedback = await  _reposiotory.GetFeedbacksAsync(id);

            return Ok(feedback);
        }


        [HttpGet("/my-feedback")]

        [Authorization.Authorize(Role.Admin, Role.Customer, Role.ParkingManager, Role.ParkingOwner)]
        public async Task<IActionResult> Get()
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
        

            return Ok(mwi.User.Feedbacks);
        }

        [HttpPost("/feedback")]

        [Authorization.Authorize(Role.Admin, Role.Customer, Role.ParkingManager, Role.ParkingOwner)]
        public IActionResult Add(FeedbackModel feedback)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            if (!ModelState.IsValid) return BadRequest(ModelState);
              _reposiotory.CreateFeedBack(feedback,mwi.User);
            return Ok("Add Success");
        }

        [HttpPut("/feedback/{id}")]

        [Authorization.Authorize(Role.Admin, Role.Customer, Role.ParkingManager, Role.ParkingOwner)]
        public IActionResult Update(string id, UpdateFeedbackModel feedback)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            if (!ModelState.IsValid) return BadRequest(ModelState);
              _reposiotory.UpdateFeedBack(id, feedback);
            return Ok("Update Success");
        }


        [HttpDelete("/feedback/{id}")]

        [Authorization.Authorize(Role.Admin, Role.Customer, Role.ParkingManager, Role.ParkingOwner)]
        public async Task<IActionResult> Delete(string id)
        {
            MiddlewareInfo? mwi = HttpContext.Items["UserTokenInfo"] as MiddlewareInfo;
            if (mwi == null) return Unauthorized("You must login to see this information");
            if (!ModelState.IsValid) return BadRequest(ModelState);
            await  _reposiotory.Delete(id);
            return Ok("Deletes Success");
        }
    }
}
