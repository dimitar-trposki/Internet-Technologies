using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBooksChatGPT.Models
{
    public class Library
    {
        public int LibraryId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public virtual ICollection<Book> Books { get; set; }
        public virtual ICollection<Member> Members { get; set; }
        public virtual ICollection<Librarian> Librarians { get; set; }

        public Library()
        {
            Books = new List<Book>();
            Members = new List<Member>();
            Librarians = new List<Librarian>();
        }
    }
}