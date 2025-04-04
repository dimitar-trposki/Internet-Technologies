﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LV3_Remastered.Models
{
    public class Hospital
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Image { get; set; }
        public virtual ICollection<Doctor> Doctors { get; set; }

        public Hospital()
        {
            Doctors = new List<Doctor>();
        }
    }
}