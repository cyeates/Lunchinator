using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Lunchinator.Web.Controllers
{
    public class AuthorizedController : ApiController
    {
      private SessionData _sessionData;

      public AuthorizedController()
      {
        _sessionData = new SessionData { LunchId = new Guid("41cfb283-cd0c-48a0-8d44-80f83e0aee7d"), UserId = 1 };
      }
      public SessionData SessionData
      {
        get { return _sessionData; } 
      }
    }
}
