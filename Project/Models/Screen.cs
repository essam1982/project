using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
namespace Project.Models
{
    public class Screen
    {
        [Key]
        public int ScreenId { get; set; }

        [Required, StringLength(15)]
        public string Name { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        [Required]
        public int NumberSeats { get; set; }

        public int WheelchairSpaces { get; set; }


    }
}