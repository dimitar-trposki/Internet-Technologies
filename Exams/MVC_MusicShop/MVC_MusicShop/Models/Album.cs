using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_MusicShop.Models
{
    public class Album
    {
        public int AlbumID { get; set; }
        public int ArtistID { get; set; }
        public int GenreID { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string AlbumArtistURL { get; set; }
        public Artist Artist { get; set; }
        public Genre Genre { get; set; }
    }
}