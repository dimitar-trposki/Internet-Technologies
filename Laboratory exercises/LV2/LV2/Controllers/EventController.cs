using LV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LV2.Controllers
{
    public class EventController : Controller
    {
        private static List<Event> events = new List<Event>()
        {
            new Event { Id = 1, Name = "Coachella", Location = "California, USA"},
            new Event { Id = 2, Name = "Tomorrowland", Location = "De Schorre, Boom"},
            new Event { Id = 3, Name = "Exit", Location = "Novi Sad, Serbia"}
        };
        // GET: Event
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowEvents()
        {
            return View(events);
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult CreateNew(Event e)
        {
            if (ModelState.IsValid)
            {
                if (events.Count() == 0)
                {
                    e.Id = 1;
                }
                else
                {
                    e.Id = events.Last().Id + 1;
                }
                events.Add(e);
                return RedirectToAction("Details", e);
            }
            else
            {
                return View("Create", e);
            }
        }

        public ActionResult Details(Event e)
        {
            return View(e);
        }

        public ActionResult Delete(int Id)
        {
            foreach (Event e in events.ToList())
            {
                if (e.Id == Id)
                {
                    events.Remove(e);
                }
            }
            return RedirectToAction("ShowEvents", "Event");
        }

        public ActionResult Edit(int Id)
        {
            foreach (Event e in events.ToList())
            {
                if (e.Id == Id)
                {
                    //return RedirectToAction("UpdateEvent", "Event", e);
                    return View("UpdateEvent", e);
                }
            }
            return View("ShowEvents");
        }

        /*public ActionResult UpdateEvent(Event e)
        {
            return View(e);
        }*/

        public ActionResult Update(Event e)
        {
            if (ModelState.IsValid)
            {
                foreach (Event ev in events)
                {
                    if (ev.Id == e.Id)
                    {
                        ev.Name = e.Name;
                        ev.Location = e.Location;
                    }
                }
                return RedirectToAction("ShowEvents");
            }
            else
            {
                return View("UpdateEvent", e);
            }
        }
    }
}