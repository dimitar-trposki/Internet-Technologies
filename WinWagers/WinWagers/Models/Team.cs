using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WinWagers.Models
{
    public class Team
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string LogoUrl { get; set; }
        public string Arena { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Draws { get; set; }
        public string Coach { get; set; }
        public int LeagueId { get; set; }
        public virtual League League { get; set; }
        public ICollection<Game> Games { get; set; }

        public Team()
        {
            Games = new List<Game>();
        }

        public int PointsSoccer()
        {
            return (Wins * 3) + (Draws * 1);
        }

        public double PointsNBA()
        {
            return (double)Wins / PlayedGames();
        }

        public double PointsEuroLeague()
        {
            return Wins * 2 + Losses;
        }

        public double PointsAmericanFootball()
        {
            return (double)Wins / PlayedGames();
        }

        public int PlayedGames()
        {
            return Wins + Losses + Draws;
        }
    }
}