using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lunchinator.Web.Models.Dtos
{
    public class InviteForm
    {
        public string LunchId { get; set; }

        [Required]
        [Display(Name="What is your friend's or coworker's email address?")]
        public string EmailAddress { get; set; }
    }
}