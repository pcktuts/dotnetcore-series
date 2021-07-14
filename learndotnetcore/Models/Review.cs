using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
namespace learndotnetcore.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int MovieId { get; set; }
        public IdentityUser User { get; set; }
        
        public Movie Moive { get; set; }
    }
}
