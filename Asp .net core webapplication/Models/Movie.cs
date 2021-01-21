﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }
        
        [StringLength(60, MinimumLength = 3), Required]
        public string Name { get; set; }

        [Display(Name = "Release Date"), DataType(DataType.Date)]              
        public DateTime ReleasedDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$"), Required, StringLength(30)]       
        public string Genre { get; set; }
       
        [Column(TypeName = "decimal(18, 2)"), Range(1, 100), DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$"), Required, StringLength(5)]
        public string Rating { get; set; }
    }
}
   