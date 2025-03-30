using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBooksChatGPT.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public string ImageUrl { get; set; }
        public int AuthorId { get; set; }
        public virtual Author Authors { get; set; }
        public virtual ICollection<Member> Members { get; set; }
        public virtual ICollection<Library> Libraries { get; set; }

        public Book()
        {
            Members = new List<Member>();
            Libraries = new List<Library>();
        }
    }
}