using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class Film
    {
        [Key]
        public int FilmId { get; set; }

        [Required, StringLength(50)]

        public string Title { get; set; }

        [Required, StringLength(100)]

        public string Genre { get; set; }

        [Required]

        public int AgeRatingId { get; set; }

        [StringLength(1000)]

        public string Summary { get; set; }

        public TimeSpan Duration { get; set; }

        [StringLength(250)]

        public string Cast { get; set; }

         [StringLength(100)]

         public string Director { get; set; }

        [StringLength(250)]

        public string Trailer { get; set; }

        [StringLength(100)]

        public string Poster { get; set; }

        [StringLength(20)]
        public string Language { get; set; }

        public Boolean IsAvailableIn3D { get; set; }

        public Boolean IsBlockbuster { get; set; }

        public Boolean IsAvailableInIMax { get; set; }

        public DateTime ReleasedDate { get; set; }

        public Double ReviewRating { get; set; }



    }
}