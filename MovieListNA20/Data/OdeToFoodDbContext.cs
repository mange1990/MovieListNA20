using System;
using Microsoft.EntityFrameworkCore;
using MovieListNA20.Models;

namespace MovieListNA20.Data
{
    public class OdeToFoodDbContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }

        public OdeToFoodDbContext(DbContextOptions options)
            : base(options)
        {


        }
    }
}
