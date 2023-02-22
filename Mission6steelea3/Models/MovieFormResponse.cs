using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6steelea3.Models
{
    public class MovieFormResponse
    {
        [Key]
        [Required]
        public int FormId { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }
        public string Notes { get; set; }
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string LentTo { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
