using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WinWagers.Models
{
    public class Ticket
    {
        [Key]
        public int Id { get; set; }
        public int Stake { get; set; }
        public double Payout { get; set; }
        public DateTime DateTime { get; set; }
        public string Status { get; set; }
        public virtual User User { get; set; }
        public ICollection<Game> Games { get; set; }
        public virtual ICollection<Game> GamesV { get; set; }

        public Ticket()
        {
            Games = new List<Game>();
            Games = new List<Game>();
        }
    }
}