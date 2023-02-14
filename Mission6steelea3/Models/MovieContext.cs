using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6steelea3.Models
{
    public class MovieContext : DbContext
    {
        //constructor
        public MovieContext (DbContextOptions<MovieContext> options) : base (options)
        {
            //leave for now
        }

        public DbSet<MovieFormResponse> responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MovieFormResponse>().HasData(

                new MovieFormResponse
                {
                    FormId = 1,
                    Title = "Inception",
                    Year = 2010,
                    Director = "Christopher Nolan",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                },
                new MovieFormResponse
                {
                    FormId = 2,
                    Title = "Eagle vs Shark",
                    Year = 2007,
                    Director = "Taika Waititi",
                    Rating = "R",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                },
                new MovieFormResponse
                {
                    FormId = 3,
                    Title = "The Peanut Butter Falcon",
                    Year = 2019,
                    Director = "Tyler Nilson, Michael Schwartz",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                }
            );
        }

    }
}
