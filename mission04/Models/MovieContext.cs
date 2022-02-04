using System;
using Microsoft.EntityFrameworkCore;

namespace mission04.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base (options)
        {
        }

        public DbSet<NewMovie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<NewMovie>().HasData
            (

                new NewMovie
                {
                    MovieID = 1,
                    Category = "Action/Adventure",
                    Title = "Batman Begins",
                    Year = 2005,
                    Director = "Christopher Nolan",
                    Rating = "PG-13",
                    Edited = false,
                },

                new NewMovie
                {
                    MovieID = 2,
                    Category = "Action/Adventure",
                    Title = "Dark Knight, The",
                    Year = 2008,
                    Director = "Christopher Nolan",
                    Rating = "PG-13",
                    Edited = false,
                },

                new NewMovie
                {
                    MovieID = 3,
                    Category = "Action/Adventure",
                    Title = "Dark Knight Rises, The",
                    Year = 2012,
                    Director = "Christopher Nolan",
                    Rating = "PG-13",
                    Edited = false,
                }
            );
        }
    }
}
