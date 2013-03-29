using Lunchinator.Data.Entities;
using Lunchinator.Domain;
using Lunchinator.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Lunchinator.Web.Controllers
{
    public class LunchesController : ApiController
    {
        private LunchService _lunchService;
        public LunchesController(LunchService eventService)
        {
            _lunchService = eventService;
        }

        public string Create(Lunch lunch, SearchParameters searchParameters)
        {
            var createdLunch = _lunchService.CreateLunch(lunch, searchParameters);
            return createdLunch.LunchId.ToString();
        }

        public Business GetRecommendation(Guid eventId)
        {
            return _lunchService.GetRecommendation(eventId);
        }
    }
}