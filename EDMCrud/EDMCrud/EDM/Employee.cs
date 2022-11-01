using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace EDMCrud.EDM
{
    public partial class Employee
    {
        [Display(Name ="Employee Id")]
        public int EmpId { get; set; }

        [Display(Name = "first Name")]
        public string Fname { get; set; }

        [Display(Name = "Salary")]
        public string Salary { get; set; }

        [Display(Name = "Mobile")]
        public string Mobile { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Display(Name = "State Id")]
        public int? StateId { get; set; }

        [Display(Name = "City Id")]
        public int? CityId { get; set; }
    }
}
