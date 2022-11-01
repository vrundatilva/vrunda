using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace EDMCrud.EDM
{
    public partial class City
    {
        [Display(Name = "City Id")]
        public int CityId { get; set; }

        [Display(Name = "City Id")]
        public string CityName { get; set; }

        [Display(Name = "State Id")]
        public int? StateId { get; set; }
    }
}
