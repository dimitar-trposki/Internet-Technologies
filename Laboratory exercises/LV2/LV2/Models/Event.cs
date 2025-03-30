using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LV2.Models
{
    public class Event
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Insert name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Insert location")]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "Локацијата треба да биде стринг со број на карактери помеѓу 5 и 30!")]
        public string Location { get; set; }
    }
}