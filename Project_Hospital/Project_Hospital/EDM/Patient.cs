using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


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

        [Display(Name ="First Name")]
        public string Fname { get; set; }

        [Display(Name = "Last Name")]

        public string Lname { get; set; }


        [Display(Name = "Email")]
        //[DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "invalid email")]

        public string Email { get; set; }


        [Display(Name = "Password")]
        [DataType(DataType.Password)]

        public string Password { get; set; }

        [Display(Name = "Image")]

        public string PImg { get; set; }

        [NotMapped]
        [DisplayName("Upload File")]
        //[Required(ErrorMessage = "Select Image")]

        public IFormFile ImageFile { get; set; }

        [Display(Name = "Mobile No")]

        public string Mobile { get; set; }

        [Display(Name = "Address")]

        public string Address { get; set; }

        [Display(Name = "State")]

        public int? SId { get; set; }

        [Display(Name = "City")]

        public int? CId { get; set; }

        public virtual City CIdNavigation { get; set; }
        public virtual State SIdNavigation { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
