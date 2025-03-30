using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WinWagers.Models
{
    public class RssNewsItem
    {
        public string Title { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
        public string PubDate { get; set; }
        public string ImageUrl { get; set; }
        public string VideoUrl { get; set; }

        public RssNewsItem() { }
    }
}