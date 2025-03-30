using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebGrease;

namespace MVC_MusicShop.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            //return View();
            //return Content("Store.Index()");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home");
            return RedirectToAction("Index", "Home", new { parameter1 = 2020, parameter2 = "corona" });
        }

        public string Browse()
        {
            return "Hello from Store.Browse()";
        }

        [Route("store/details/{artistid:range(1,5)}/{artistalbum:regex(\\w*\\d{4})}")]
        public string Details(int? artistid, string artistalbum)
        {
            string message = "Store.Details, ID = " + artistid + ", album = " + artistalbum;
            return message;
        }
    }
}