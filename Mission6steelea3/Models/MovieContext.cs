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

        public DbSet<MovieFormResponse> Responses { get; set; }
        public DbSet<Category> Categories { get; set; }


        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryId=1, Categorys="Horror"},
                new Category { CategoryId = 2, Categorys = "Action" },
                new Category { CategoryId = 3, Categorys = "Drama" },
                new Category { CategoryId = 4, Categorys = "Romance" },
                new Category { CategoryId = 5, Categorys = "SciFi" },
                new Category { CategoryId = 6, Categorys = "Comedy" }
                );

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
                    Notes = "",
                    CategoryId = 5
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
                    Notes = "",
                    CategoryId = 4
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
                    Notes = "",
                    CategoryId = 3
                }
            );
        }

    }
}
