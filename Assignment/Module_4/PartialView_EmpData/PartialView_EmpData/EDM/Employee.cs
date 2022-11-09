using System;
using System.Collections.Generic;

#nullable disable

namespace PartialView_EmpData.EDM
{
    public partial class Employee
    {
        public int EmpId { get; set; }
        public string Fname { get; set; }
        public string Salary { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public int StateId { get; set; }
        public int CityId { get; set; }
    }
}
