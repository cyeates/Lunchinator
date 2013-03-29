using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Lunchinator.Domain.Dtos
{
    public class LunchForm
    {
        [Required]
        public string Name { get; set; }
        public DateTime Date { get; set; }
                
        public string Time { get; set; }

        [Display(Name = "City or Zip Code")]
        public string Where { get; set; }
        public int Distance { get; set; }
    }
}
