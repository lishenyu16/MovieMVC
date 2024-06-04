using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MovieMVC.Models
{
    public class MovieDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}