using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LV3.Models
{
    public class Doctor
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [Display(Name="Болница")]
        public int HospitalId { get; set; }
        public virtual Hospital Hospital { get; set; }
        public virtual ICollection<Patient> Patients { get; set; }

        public Doctor()
        {
            Hospital = null;
            Patients = new List<Patient>();
        }
    }
}