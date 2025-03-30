using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AV6.Models
{
    public class Client
    {
        public int Id { get; set; }
        [Required]
        [Range(1, 99, ErrorMessage ="Age must be between 1 and 99!")]
        public int Age { get; set; }
        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string MemberCard { get; set; }
    }
}