using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WinWagers.Models
{
    public class TeamStanding
    {
        public int Position { get; set; }
        public string TeamName { get; set; }
        public int PlayedGames { get; set; }
        public int Won { get; set; }
        public int Draw { get; set; }
        public int Lost { get; set; }
        public int Points { get; set; }
    }
}