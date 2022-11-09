using System;
using System.Collections.Generic;

#nullable disable

namespace Project_Hospital.EDM
{
    public partial class Patient
    {
        public Patient()
        {
            Appointments = new HashSet<Appointment>();
        }

        public int PatId { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PImg { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public int? SId { get; set; }
        public int? CId { get; set; }

        public virtual City CIdNavigation { get; set; }
        public virtual State SIdNavigation { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
