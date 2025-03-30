using MVC_MusicShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_MusicStore.ViewModels
{
    public class ArtistAlbumViewModel
    {
        public Artist Artist { get; set; }
        public List<Album> Albums { get; set; }

        public ArtistAlbumViewModel()
        {
            Albums = new List<Album>();
        }
    }
}