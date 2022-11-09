using System;
using System.Collections.Generic;

#nullable disable

namespace Project_Hospital.EDM
{
    public partial class Hospital
    {
        public Hospital()
        {
            Appointments = new HashSet<Appointment>();
            Doctors = new HashSet<Doctor>();
        }

        public int HospId { get; set; }
        public string Hname { get; set; }
        public string HLogImg { get; set; }
        public string Mobile { get; set; }
        public string HospEmail { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<Doctor> Doctors { get; set; }
    }
}
