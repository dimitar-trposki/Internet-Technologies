using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LV3_Remastered.Models
{
    public enum Gender
    {
        No_selection, Male, Female
    }

    public class Patient
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public Gender Gender { get; set; }
        [RegularExpression(@"\d{5}", ErrorMessage = "The code must contain only 5 digits!")]
        [Display(Name = "Код на пациентот")]
        public int PatientCode { get; set; }
        public virtual ICollection<Doctor> Doctors { get; set; }

        public Patient()
        {
            Doctors = new List<Doctor>();
        }
    }
}