﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AlbumsMVC_Kolokviumska.Models
{
    public class Genre
    {
        [Display(Name = "Id")]
        public int GenreId { get; set; }
        [Display(Name = "Genre Name")]
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Album> Albums { get; set; }

        public Genre()
        {
            Albums = new List<Album>();
        }
    }
}