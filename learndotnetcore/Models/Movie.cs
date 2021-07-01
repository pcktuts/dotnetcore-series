﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace learndotnetcore.Models
{
    public class Movie
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(4)]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }  
        [Range(100, 1000, ErrorMessage = "Invalid price")]
        public decimal Price { get; set; }
    }
}
