using MVC_MusicShop.Models;
using MVC_MusicStore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_MusicShop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "I like cake.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        /*public ActionResult List()
        {
            var albums = new List<Album>();
            for (int i = 0; i < 10; i++)
            {
                albums.Add(new Album { Title = "Album" + i });
            }
            ViewBag.Albums = albums;
            return View();
        }*/

        public ActionResult List()
        {
            var albums = new List<Album>();
            for (int i = 0; i < 10; i++)
            {
                albums.Add(new Album { Title = "Album" + i });
            }
            return View(albums);
        }

        public ActionResult ListArtistAlbums()
        {
            var artist = new Artist() { Name = "Artist1" };
            var albums = new List<Album>();
            for (int i = 0; i < 10; i++)
            {
                albums.Add(new Album { Title = "Album" + i });
            }

            var viewModel = new ArtistAlbumViewModel()
            {
                Artist = artist,
                Albums = albums
            };

            return View(viewModel);
        }

        public ActionResult ShowSearch()
        {
            return View();
        }

        public ActionResult Search()
        {
            var albums = new List<Album>();
            for (int i = 0; i < 10; i++)
            {
                albums.Add(new Album { Title = "Album" + i });
            }
            return View();
        }
    }
}