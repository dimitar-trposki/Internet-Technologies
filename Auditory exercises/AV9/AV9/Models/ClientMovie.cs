using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AV9.Models
{
    public class ClientMovie
    {
        public int MovieId { get; set; }
        public int ClientId { get; set; }
        public Movie Movie { get; set; }
        public List<Client> Clients { get; set; }

        public ClientMovie()
        {
            Clients = new List<Client>();
        }
    }
}