using System;
using System.Collections.Generic;

#nullable disable

namespace Project_Hospital.EDM
{
    public partial class State
    {
        public State()
        {
            Cities = new HashSet<City>();
            Patients = new HashSet<Patient>();
        }

        public int StatId { get; set; }
        public string StateName { get; set; }

        public virtual ICollection<City> Cities { get; set; }
        public virtual ICollection<Patient> Patients { get; set; }
    }
}
