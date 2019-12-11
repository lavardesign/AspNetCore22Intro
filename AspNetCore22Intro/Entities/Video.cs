using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using AspNetCore22Intro.Models;

namespace AspNetCore22Intro.Entities
{
    public class Video
    {
        public int Id { get; set; }

        [Required, MinLength(3), MaxLength(80)]
        public string Title { get; set; }

        //public int GenreId { get; set; }

        [Display(Name = "Film Genre")]
        public Genres Genre { get; set; }
    }
}
