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

    }
}
