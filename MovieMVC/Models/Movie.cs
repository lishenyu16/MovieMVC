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
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }

        [Display(Name = "Movie Price")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal Price { get; set; }
    }

    public class MovieDbContext: DbContext
    {
        public DbSet<Movie> Movies { get; set;}
    }
}