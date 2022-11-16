using System;
using System.Collections.Generic;

#nullable disable

namespace Project_Hospital.EDM
{
    public partial class Doctor
    {
        public int DocId { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Qualification { get; set; }
        public string Specialitites { get; set; }
        public int? HId { get; set; }

        public virtual TblHospital HIdNavigation { get; set; }
    }
}
