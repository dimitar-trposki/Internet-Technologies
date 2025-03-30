using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WinWagers.Models
{
    public class TicketViewModel
    {
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        [Range(1, double.MaxValue, ErrorMessage = "Stake must be greater than zero")]
        public double Stake { get; set; }

        public double Payout { get; set; }

        public DateTime DateTime { get; set; }

        public string Status { get; set; }

        // List of available games (for selection)
        public List<Game> AvailableGames { get; set; }

        // Selected games
        public List<int> SelectedGameIds { get; set; }

        // Odds selected for each game
        public Dictionary<int, double> SelectedOdds { get; set; }

        public TicketViewModel()
        {
            SelectedGameIds = new List<int>();
            AvailableGames = new List<Game>();
            SelectedOdds = new Dictionary<int, double>();
        }

        //public int Id { get; set; }

        //[Required]
        //public int UserId { get; set; }

        //[Required]
        //[Range(1, double.MaxValue, ErrorMessage = "Stake must be greater than zero")]
        //public double Stake { get; set; }

        //public double Payout { get; set; }

        //public DateTime DateTime { get; set; }

        //public string Status { get; set; }

        //// List of available games (for the dropdown)
        //public List<SelectListItem> AvailableGames { get; set; }

        //// Selected game IDs
        //public List<int> SelectedGameIds { get; set; }

        //// Odds for the selected games
        //public double SelectedOdds { get; set; }

        //public TicketViewModel()
        //{
        //    SelectedGameIds = new List<int>();
        //    AvailableGames = new List<SelectListItem>();
        //}
    }
}