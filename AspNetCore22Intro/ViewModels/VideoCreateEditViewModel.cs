using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore22Intro.Models;

namespace AspNetCore22Intro.ViewModels
{
    public class VideoCreateEditViewModel
    {
        public int id { get; set; }

        [Required, MinLength(3), MaxLength(80)]
        public string Title { get; set; }

        public Genres Genre { get; set; }
    }
}
