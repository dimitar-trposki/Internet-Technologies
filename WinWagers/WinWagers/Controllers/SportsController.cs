using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using WinWagers.Models;
using HtmlAgilityPack;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;
using System.Xml;
using Microsoft.Ajax.Utilities;

namespace WinWagers.Controllers
{
    public class SportsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public List<Game> GamesPremierLeague { get; set; } = new List<Game>();
        public List<Game> GamesLaLiga { get; set; } = new List<Game>();
        public List<Game> GamesBundesliga { get; set; } = new List<Game>();
        public List<Game> GamesNBA { get; set; } = new List<Game>();
        public List<Game> GamesEuroLeague { get; set; } = new List<Game>();
        public List<Game> GamesNFL { get; set; } = new List<Game>();
        private readonly string _premierLeagueRssUrl = "http://feeds.bbci.co.uk/sport/football/rss.xml";
        private readonly string _laligaRssUrl = "https://www.eyefootball.com/rss/La-Liga";
        private readonly string _bundesligaRssUrl = "https://www.eyefootball.com/rss/Bundesliga";
        private readonly string _nbaRssUrl = "https://www.espn.com/espn/rss/nba/news";
        private readonly string _nflRssUrl = "https://www.espn.com/espn/rss/nfl/news";

        // GET: Sports
        public ActionResult Index()
        {
            return View(db.Sports.ToList());
        }

        // GET: Sports/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sport sport = db.Sports.Find(id);
            if (sport == null)
            {
                return HttpNotFound();
            }
            return View(sport);
        }

        // GET: Sports/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sports/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,LogoUrl,Description")] Sport sport)
        {
            if (ModelState.IsValid)
            {
                db.Sports.Add(sport);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sport);
        }

        // GET: Sports/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sport sport = db.Sports.Find(id);
            if (sport == null)
            {
                return HttpNotFound();
            }
            return View(sport);
        }

        // POST: Sports/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,LogoUrl,Description")] Sport sport)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sport).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sport);
        }

        // GET: Sports/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sport sport = db.Sports.Find(id);
            if (sport == null)
            {
                return HttpNotFound();
            }
            return View(sport);
        }

        // POST: Sports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sport sport = db.Sports.Find(id);
            db.Sports.Remove(sport);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        private async Task<List<RssNewsItem>> GetNewsFromRssFeed(string rssFeedUrl)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var response = await client.GetStringAsync(rssFeedUrl);
                    var xDocument = XDocument.Parse(response);

                    var items = (from x in xDocument.Descendants("item")
                                 select new RssNewsItem
                                 {
                                     Title = x.Element("title")?.Value,
                                     Link = x.Element("link")?.Value,
                                     Description = x.Element("description")?.Value,
                                     PubDate = x.Element("pubDate")?.Value
                                 }).ToList();

                    return items;
                }
            }
            catch (XmlException ex)
            {
                Console.WriteLine($"Error parsing RSS feed: {ex.Message}");
                return new List<RssNewsItem>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General error: {ex.Message}");
                return new List<RssNewsItem>();
            }
        }

        public List<Team> TeamsByLeague(int Id)
        {
            return db.Teams.Where(t => t.LeagueId == Id).ToList();
        }

        public List<Team> SortedTeams(List<Team> teams)
        {
            return teams.OrderByDescending(t => t.PointsSoccer()).ToList();
        }

        public List<Team> SortedTeamsByPct(List<Team> teams)
        {
            return teams.OrderByDescending(t => t.PointsNBA()).ToList();
        }

        public ActionResult Soccer()
        {
            var premierleague = db.Leagues.FirstOrDefault(l => l.Name == "Premier League");
            ViewBag.PremierLeagueName = premierleague.Name;
            ViewBag.PremierLeagueLogoUrl = premierleague.LogoUrl;
            ViewBag.PremierLeagueDescription = premierleague.Description;
            var laLiga = db.Leagues.FirstOrDefault(l => l.Name == "LaLiga");
            ViewBag.LaLigaName = laLiga.Name;
            ViewBag.LaLigaLogoUrl = laLiga.LogoUrl;
            ViewBag.LaLigaDescription = laLiga.Description;
            var bundesliga = db.Leagues.FirstOrDefault(l => l.Name == "Bundesliga");
            ViewBag.BundesligaName = bundesliga.Name;
            ViewBag.BundesligaLogoUrl = bundesliga.LogoUrl;
            ViewBag.BundesligaDescription = bundesliga.Description;
            return View();
        }

        public ActionResult PremierLeague()
        {
            var league = db.Leagues.FirstOrDefault(l => l.Name == "Premier League");
            ViewBag.LeagueName = league.Name;
            ViewBag.LeagueLogoUrl = league.LogoUrl;
            return View();
        }

        public async Task<ActionResult> PremierLeagueNews()
        {
            var newsItems = await GetNewsFromRssFeed(_premierLeagueRssUrl);
            ViewBag.LeagueName = "Premier League";
            return View(newsItems);
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

        public List<Game> GetGames(int id)
        {
            Random random = new Random();
            List<Game> games = new List<Game>();
            for (int i = 0; i < 15; i++)
            {
                List<Team> teams = TeamsByLeague(id);
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
            return games;
        }

        public ActionResult PremierLeagueGames()
        {
            if (GamesPremierLeague.Count == 0)
            {
                GamesPremierLeague = GetGames(1);
            }
            return View(GamesPremierLeague);
        }

        public ActionResult PremierLeagueTable()
        {
            List<Team> teams = TeamsByLeague(1);

            var sortedTeams = SortedTeams(teams);

            return View(sortedTeams);
        }

        public ActionResult LaLiga()
        {
            var league = db.Leagues.FirstOrDefault(l => l.Name == "LaLiga");
            ViewBag.LeagueName = league.Name;
            ViewBag.LeagueLogoUrl = league.LogoUrl;
            return View();
        }

        public async Task<ActionResult> LaLigaNews()
        {
            var newsItems = await GetNewsFromRssFeed(_laligaRssUrl);
            ViewBag.LeagueName = "La Liga";
            return View(newsItems);
        }

        public ActionResult LaLigaGames()
        {
            if (GamesLaLiga.Count == 0)
            {
                GamesLaLiga = GetGames(2);
            }
            return View(GamesLaLiga);
        }

        public ActionResult LaLigaTable()
        {
            List<Team> teams = TeamsByLeague(2);

            var sortedTeams = SortedTeams(teams);

            return View(sortedTeams);
        }

        public ActionResult Bundesliga()
        {
            var league = db.Leagues.FirstOrDefault(l => l.Name == "Bundesliga");
            ViewBag.LeagueName = league.Name;
            ViewBag.LeagueLogoUrl = league.LogoUrl;
            return View();
        }

        public async Task<ActionResult> BundesligaNews()
        {
            var newsItems = await GetNewsFromRssFeed(_bundesligaRssUrl);
            ViewBag.LeagueName = "Bundesliga";
            return View(newsItems);
        }

        List<Game> games = new List<Game>();

        public ActionResult BundesligaGames()
        {
            if (GamesBundesliga.Count == 0)
            {
                GamesBundesliga = GetGames(3);
            }
            return View(GamesBundesliga);
        }

        public ActionResult BundesligaTable()
        {
            List<Team> teams = TeamsByLeague(3);

            var sortedTeams = SortedTeams(teams);

            return View(sortedTeams);
        }

        public ActionResult Basketball()
        {
            var nba = db.Leagues.FirstOrDefault(l => l.Name == "NBA");
            ViewBag.NBAName = nba.Name;
            ViewBag.NBALogoUrl = nba.LogoUrl;
            ViewBag.NBADescription = nba.Description;
            var euroleague = db.Leagues.FirstOrDefault(l => l.Name == "EuroLeague");
            ViewBag.EuroLeagueName = euroleague.Name;
            ViewBag.EuroLeagueLogoUrl = euroleague.LogoUrl;
            ViewBag.EuroLeagueDescription = euroleague.Description;
            return View();
        }

        public ActionResult NBA()
        {
            return View();
        }

        public async Task<ActionResult> NBANews()
        {
            var newsItems = await GetNewsFromRssFeed(_nbaRssUrl);
            ViewBag.LeagueName = "NBA";
            return View(newsItems);
        }

        public ActionResult NBAGames()
        {
            if (GamesNBA.Count == 0)
            {
                GamesNBA = GetGames(4);
            }
            return View(GamesNBA);
        }

        public ActionResult NBATable()
        {
            List<Team> teams = TeamsByLeague(4);

            var sortedTeams = SortedTeamsByPct(teams);

            return View(sortedTeams);
        }

        public ActionResult EuroLeague()
        {
            return View();
        }

        public async Task<ActionResult> EuroLeagueNews()
        {
            var newsItems = await GetEuroLeagueNews();
            return View(newsItems);
        }

        private async Task<List<RssNewsItem>> GetEuroLeagueNews()
        {
            string url = "https://www.euroleaguebasketball.net/news/";
            HtmlWeb web = new HtmlWeb();
            var htmlDoc = await web.LoadFromWebAsync(url);
            var newsList = new List<RssNewsItem>();
            var articles = htmlDoc.DocumentNode.SelectNodes("//div[contains(@class, 'article-title')]");
            if (articles != null)
            {
                foreach (var article in articles)
                {
                    var titleNode = article.SelectSingleNode(".//a");
                    var link = titleNode.GetAttributeValue("href", "");
                    var title = titleNode.InnerText.Trim();

                    newsList.Add(new RssNewsItem
                    {
                        Title = title,
                        Link = $"https://www.euroleaguebasketball.net{link}",
                        Description = "EuroLeague Basketball News",
                        PubDate = DateTime.Now.ToString()
                    });
                }
            }

            return newsList;
        }

        public ActionResult EuroLeagueGames()
        {
            if (GamesEuroLeague.Count == 0)
            {
                GamesEuroLeague = GetGames(5);
            }
            return View(GamesEuroLeague);
        }

        public ActionResult EuroLeagueTable()
        {
            List<Team> teams = TeamsByLeague(5);

            var sortedTeams = SortedTeams(teams);

            return View(sortedTeams);
        }

        public ActionResult AmericanFootball()
        {
            var nfl = db.Leagues.FirstOrDefault(l => l.Name == "NFL");
            ViewBag.NFLName = nfl.Name;
            ViewBag.NFLLogoUrl = nfl.LogoUrl;
            ViewBag.NFLDescription = nfl.Description;
            return View();
        }

        public ActionResult NFL()
        {
            return View();
        }

        public async Task<ActionResult> NFLNews()
        {
            var newsItems = await GetNewsFromRssFeed(_nflRssUrl);
            ViewBag.LeagueName = "NFL";
            return View(newsItems);
        }

        public ActionResult NFLGames()
        {
            if (GamesNFL.Count == 0)
            {
                GamesNFL = GetGames(6);
            }
            return View(GamesNFL);
        }

        public ActionResult NFLTable()
        {
            List<Team> teams = TeamsByLeague(6);

            var sortedTeams = SortedTeamsByPct(teams);

            return View(sortedTeams);
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
