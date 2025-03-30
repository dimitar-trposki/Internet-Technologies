using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LV3.Models
{
    public class PatientDoctor
    {
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public Doctor Doctor { get; set; }
        public List<Patient> Patients { get; set; }

        public PatientDoctor()
        {
            Patients = new List<Patient>();
        }
    }
}