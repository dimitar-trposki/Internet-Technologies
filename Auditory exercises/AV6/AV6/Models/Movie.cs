using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AV6.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string DownloadURL { get; set; }
        public string ImageURL { get; set; }
        public float Rating { get; set; }
    }
}