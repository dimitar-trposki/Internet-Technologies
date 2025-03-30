using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AV9.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string DownloadURL { get; set; }
        public string ImageURL { get; set; }
        public float Rating { get; set; }
        public virtual ICollection<Client> clients { get; set; }

        public Movie()
        {
            clients = new List<Client>();
        }
    }
}