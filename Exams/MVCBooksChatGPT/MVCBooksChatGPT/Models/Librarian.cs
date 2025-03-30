using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBooksChatGPT.Models
{
    public class Librarian
    {
        public int LibrarianId { get; set; }
        public string Name { get; set; }
        public int LibraryId { get; set; }
        public virtual Library Library { get; set; }

        public Librarian() { }
    }
}