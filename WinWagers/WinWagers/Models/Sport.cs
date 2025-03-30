using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WinWagers.Models
{
    public class Sport
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string LogoUrl { get; set; }
        public string Description { get; set; }
        public virtual ICollection<League> Leagues { get; set; }

        public Sport()
        {
            Leagues = new List<League>();
        }
    }
}