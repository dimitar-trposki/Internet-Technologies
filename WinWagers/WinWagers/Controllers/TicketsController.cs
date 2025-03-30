using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WinWagers.Models;

namespace WinWagers.Controllers
{
    public class TicketsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Tickets
        public ActionResult Index()
        {
            return View(db.Tickets.ToList());
        }

        // GET: Tickets/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ticket ticket = db.Tickets.Find(id);
            if (ticket == null)
            {
                return HttpNotFound();
            }
            return View(ticket);
        }

        //GET: Tickets/Create
        public ActionResult Create()
        {
            var games = GetGames(); // Fetch the available games

            var viewModel = new TicketViewModel
            {
                UserId = GetLoggedInUserId(), // Method to get logged-in user's ID
                AvailableGames = games
            };

            return View(viewModel);
        }

        private string GetLoggedInUserId()
        {
            return User.Identity.GetUserId();
        }

        // POST: Tickets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "Id,UserId,Stake,Payout,DateTime,Status")] Ticket ticket)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Tickets.Add(ticket);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(ticket);
        //}

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TicketViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                // Recalculate payout
                double selectedOdds = viewModel.SelectedOdds.Sum(odds => odds.Value); // Aggregate selected odds
                double payout = viewModel.Stake * selectedOdds;

                var ticket = new Ticket
                {
                    Stake = (int)viewModel.Stake,
                    Payout = viewModel.Payout,
                    DateTime = DateTime.Now,
                    Status = "Pending"
                };

                db.Tickets.Add(ticket);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            // Reload available games
            viewModel.AvailableGames = db.Games.ToList();
            return View(viewModel);
        }


        // GET: Tickets/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ticket ticket = db.Tickets.Find(id);
            if (ticket == null)
            {
                return HttpNotFound();
            }
            return View(ticket);
        }

        // POST: Tickets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,UserId,Stake,Payout,DateTime,Status")] Ticket ticket)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ticket).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ticket);
        }

        // GET: Tickets/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ticket ticket = db.Tickets.Find(id);
            if (ticket == null)
            {
                return HttpNotFound();
            }
            return View(ticket);
        }

        // POST: Tickets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ticket ticket = db.Tickets.Find(id);
            db.Tickets.Remove(ticket);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public List<Team> TeamsByLeague(int Id)
        {
            return db.Teams.Where(t => t.LeagueId == Id).ToList();
        }

        public DateTime GenerateRandomDate()
        {
            Random random = new Random();
            DateTime now = DateTime.Now;
            DateTime nextJanuary = new DateTime(now.Year + 1, 1, 1);
            TimeSpan dateRange = nextJanuary - now;
            int randomDays = random.Next(0, dateRange.Days + 1);
            DateTime randomDate = now.AddDays(randomDays).Date;
            int randomHour = random.Next(12, 22);
            return now.AddSeconds(randomHour);
        }

        public List<Game> GetGames()
        {
            Random random = new Random();
            List<Game> games = new List<Game>();
            for (int j = 1; j <= 6; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    List<Team> teams = TeamsByLeague(j);
                    Team homeTeam = teams[random.Next(0, 10)];
                    Team awayTeam = teams[random.Next(0, 10)];
                    while (homeTeam == awayTeam)
                    {
                        awayTeam = teams[random.Next(0, 10)];
                    }
                    double oddsHome = Math.Round(1.01 + (random.NextDouble() * 11), 2);
                    double oddsDraw = Math.Round(1.01 + (random.NextDouble() * 5), 2);
                    double oddsAway = Math.Round(1.01 + (random.NextDouble() * 11), 2);
                    DateTime dateTime = GenerateRandomDate();
                    dateTime = new DateTime(dateTime.Year, dateTime.Month, i + 1, dateTime.Hour, dateTime.Minute, dateTime.Second);
                    games.Add(new Game { OddsHome = oddsHome, OddsAway = oddsAway, OddsDraw = oddsDraw, HomeTeam = homeTeam, AwayTeam = awayTeam, DateTime = dateTime });
                }
            }
            return games;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
