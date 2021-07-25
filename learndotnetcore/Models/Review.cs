using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
namespace learndotnetcore.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int MovieId { get; set; }
        public string UserId { get; set; }

        [NotMapped]
        [ForeignKey("UserId")]
        public virtual IdentityUser ApplicationUser { get; set; }

        public Movie Moive { get; set; }
    }
}
