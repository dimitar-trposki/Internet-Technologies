﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AV9.Models
{
    public class MovieRentals
    {
        public Movie movie { get; set; }
        public List<Client> customers { get; set; }
    }
}