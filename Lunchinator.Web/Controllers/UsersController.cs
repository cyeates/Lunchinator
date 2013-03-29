using Breeze.WebApi;
using Lunchinator.Data;
using Lunchinator.Data.Entities;
using Lunchinator.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json.Linq;

namespace Lunchinator.Web.Controllers
{
    //[BreezeController]
    public class UsersController : AuthorizedController
    {
        private UserService _userService;
        private EFContextProvider<LunchinatorContext> _contextProvider;
        public UsersController(UserService userService)
        {
            _userService = userService;
            _contextProvider = new EFContextProvider<LunchinatorContext>();
        }

        [HttpGet]
        public string Metadata()
        {
          return _contextProvider.Metadata();
        }

        [HttpGet]
        public User CurrentUser()
        {
          return _userService.GetUser(SessionData.UserId);
        }

        [HttpPost]
        public HttpResponseMessage SaveRating(Rating rating)
        {
            _userService.SaveRating(rating, this.SessionData.UserId);
            var response = Request.CreateResponse(HttpStatusCode.Created, rating);

            return response;
        }

        [HttpGet]
        public IEnumerable<Business> BusinessesToRate()
        {

            var businesses = _userService.GetBusinessesToRateForEvent(this.SessionData.LunchId);
            if (businesses != null)
              return businesses;

            throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
        }

        //[HttpPost]
        //public SaveResult SaveChanges(JObject saveBundle)
        //{
        //  return _contextProvider.SaveChanges(saveBundle);
        //}
        
    }
}
