using System;
using System.Collections.Generic;

#nullable disable

namespace Project_Hospital.EDM
{
    public partial class Appointment
    {
        public int AppId { get; set; }
        public int? PtId { get; set; }
        public int? HopId { get; set; }
        public string DId { get; set; }
        public DateTime? AppoDate { get; set; }
        public string AppoStatus { get; set; }

        public virtual Hospital Hop { get; set; }
        public virtual Patient Pt { get; set; }
    }
}
