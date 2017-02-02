using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class AgeRating
    {
        [Key]
        public int AgeRatingID { get; set; }

        [Required, StringLength(3)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        
    }
}