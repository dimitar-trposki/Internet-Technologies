using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCBooksChatGPT.Models
{
    public class Member
    {
        public int MemberId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        [Display(Name="Членски број")]
        [RegularExpression(@"\d{6}", ErrorMessage = "The membership number must be 6 digits!")]
        public int MembershipNumber { get; set; }
        public string Status { get; set; }
        public virtual ICollection<Book> Books { get; set; }

        public Member()
        {
            Books = new List<Book>();
        }
    }
}