using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Project_Hospital.EDM
{
    public partial class Doctor
    {
        public Doctor()
        {
            Appointments = new HashSet<Appointment>();
        }

        public int Doc_Id { get; set; }

        [Display(Name ="First Name")]
        public string Fname { get; set; }

        [Display(Name = "Last Name")]

        public string Lname { get; set; }


        [Display(Name = "Qualification")]

        public string Qualification { get; set; }


        [Display(Name = "Specialitites")]

        public string Specialitites { get; set; }

        [Display(Name = "Hospital Name")]
        public int? HId { get; set; }

        public virtual TblHospital HIdNavigation { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }

    }
}
