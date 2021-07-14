using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using learndotnetcore.Models;

namespace learndotnetcore.Data
{
    public class MvcMovieContext : IdentityDbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }

        public DbSet<learndotnetcore.Models.Review> Review { get; set; }
        
    }
}
