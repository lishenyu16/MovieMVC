using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MovieMVC.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3 )]
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [StringLength (100, MinimumLength = 2 )]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        public string Genre { get; set; }

        [Display(Name = "Movie Price")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        [Range(1.0, 100.0)]
        [DataType (DataType.Currency)]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [StringLength(10)]
        public string Rating { get; set; }
    }
}