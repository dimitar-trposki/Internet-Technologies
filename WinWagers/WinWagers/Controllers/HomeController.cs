using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using WinWagers.Models;

namespace WinWagers.Controllers
{
    public class HomeController : Controller
    {
        private readonly string _rssFeedUrl = "http://www.espn.com/espn/rss/news"; // ESPN RSS feed URL

        public async Task<ActionResult> Index()
        {
            var newsItems = await GetNewsFromRssFeed();
            return View(newsItems);
        }

        private async Task<List<RssNewsItem>> GetNewsFromRssFeed()
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetStringAsync(_rssFeedUrl);
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

        /*public ActionResult Index()
        {
            return View();
        }*/

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}