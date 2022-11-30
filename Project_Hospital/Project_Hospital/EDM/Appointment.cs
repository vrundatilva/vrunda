using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Project_Hospital.EDM
{
    public partial class Appointment
    {
        
        public int AppId { get; set; }

        [Display(Name ="Patient Name")]
        public int? PtId { get; set; }

        [Display(Name = "hospital Name")]

        public int? HopId { get; set; }


        [Display(Name = "Doctor Name")]

        public int? DId { get; set; }

        [Display(Name = "Appoint Date")]
        [DataType(DataType.Date)]
        public DateTime? AppoDate { get; set; }


        [Display(Name = "Appoint Status")]

        public string AppoStatus { get; set; }

        [NotMapped]
        public string PatientName { get; set; }

        [NotMapped]

        public string HospitalName { get; set; }

        [NotMapped]

        public string DoctorName { get; set; }

        public virtual TblHospital Hop { get; set; }
        public virtual Patient Pt { get; set; }
        public virtual Doctor d { get; set; }

    }
}
