using AV6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AV6.Controllers
{
    public class MoviesController : Controller
    {
        public static List<Movie> Movies = new List<Movie>() { new Movie() { Title = "Shrek", Rating = 5, DownloadURL = "#", ImageURL = @"https://upload.wikimedia.org/wikipedia/en/4/4d/Shrek_%28character%29.png" } };
        public static List<Client> Clients = new List<Client>() { };

        // GET: Movies
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAllMovies()
        {
            return View(Movies);
        }

        public ActionResult ShowMovie(int id)
        {
            MovieRentals model = new MovieRentals();
            model.Clients = Clients;
            model.Movie = Movies.ElementAt(id - 1);
            return View(model);
        }
        public ActionResult ShowClient(int id)
        {
            return View(Clients.ElementAt(id));
        }

        public ActionResult NewMovie()
        {
            Movie model = new Movie();
            return View(model);
        }

        public ActionResult NewClient()
        {
            Client model = new Client();
            return View(model);
        }

        [HttpPost]
        public ActionResult InsertClient(Client model)
        {
            if (ModelState.IsValid == false)
            {
                return View("NewClient", model);
            }
            Clients.Add(model);
            return View("GetAllMovies", Movies);
        }

        [HttpPost]
        public ActionResult InsertMovie(Movie model)
        {
            if (ModelState.IsValid == false)
            {
                return View("NewMovie", model);
            }
            Movies.Add(model);
            return View("GetAllMovies", Movies);
        }

        public ActionResult EditMovie(int id)
        {
            var model = Movies.ElementAt(id - 1);
            model.Id = id;
            return View(model);
        }
        [HttpPost]
        public ActionResult EditMovie(Movie model)
        {
            if (ModelState.IsValid == false)
            {
                return View("NewMovie", model);
            }
            var forUpdate = Movies.ElementAt(model.Id - 1);
            forUpdate.Title = model.Title;
            forUpdate.ImageURL = model.ImageURL;
            forUpdate.Rating = model.Rating;
            return View("GetAllMovies", Movies);
        }

        public ActionResult DeleteMovie(int id)
        {
            if (Movies.Count() >= id)
            {
                Movies.RemoveAt(id - 1);
            }
            return View("GetAllMovies", Movies);
        }
    }
}