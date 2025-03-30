using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WinWagers.Models
{
    public class League
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string LogoUrl { get; set; }
        public int SportId { get; set; }
        public virtual Sport Sport { get; set; }
        public virtual ICollection<Team> Teams { get; set; }

        public League()
        {
            Teams = new List<Team>();
        }
    }
}