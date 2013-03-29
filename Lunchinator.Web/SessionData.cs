using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lunchinator.Web
{
  public class SessionData
  {
    public Guid LunchId { get; set; }
    public int UserId { get; set; }
  }
}