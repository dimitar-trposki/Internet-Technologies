using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WinWagers.Models
{
    public class Game
    {
        [Key]
        public int Id { get; set; }
        public double OddsHome { get; set; }
        public double OddsAway { get; set; }
        public double OddsDraw { get; set; }
        public double Bet { get; set; }
        public string Status { get; set; }
        public string Result { get; set; }
        public DateTime DateTime { get; set; }
        public int LeagueId { get; set; }
        public virtual Team HomeTeam { get; set; }
        public virtual Team AwayTeam { get; set; }
        public virtual League League { get; set; }

        public Game() { }
    }
}