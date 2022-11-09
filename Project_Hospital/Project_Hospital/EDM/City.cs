using System;
using System.Collections.Generic;

#nullable disable

namespace Project_Hospital.EDM
{
    public partial class City
    {
        public City()
        {
            Patients = new HashSet<Patient>();
        }

        public int CityId { get; set; }
        public string CityName { get; set; }
        public int? StId { get; set; }

        public virtual State St { get; set; }
        public virtual ICollection<Patient> Patients { get; set; }
    }
}
