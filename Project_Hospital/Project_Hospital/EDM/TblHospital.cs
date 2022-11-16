using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Project_Hospital.EDM
{
    public partial class TblHospital
    {
        public TblHospital()
        {
            Appointments = new HashSet<Appointment>();
            Doctors = new HashSet<Doctor>();
        }
        [Display(Name ="Hospital Id")]
        public int HospId { get; set; }

        [Display(Name = "Hospital Name")]
        //[Required(ErrorMessage = "Enter First Name")]
        //[RegularExpression("[a-zA-Z]+", ErrorMessage = "Only alphabets..!!")]

        public string Hname { get; set; }


        [Display(Name = "Hospital Logo")]

        public string HLogImg { get; set; }
        [NotMapped]
        [DisplayName("Upload File")]
        [Required(ErrorMessage = "Select Image")]

        public IFormFile ImageFile { get; set; }

        [Display(Name = "Mobile number")]
        //[Required(ErrorMessage = "Enter mobile number")]
        //[RegularExpression(@"\+91\-[9876]\d{9}", ErrorMessage = "Invalid Mobile No.")]

        public string Mobile { get; set; }

        [Display(Name = "Email")]
        //[DataType(DataType.EmailAddress)]
        //[EmailAddress(ErrorMessage = "invalid email")]
        public string HospEmail { get; set; }


       // [Required]
        //[Display(Name = "Password")]
        //[DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*\d)(?=.*[A-Z])(?=.*[a-z])(?=.*[a-zA-Z!#$%&? ])[a-zA-Z0-9!#$%&?]{8,20}$", ErrorMessage = "Password is weak.")]
        public string Password { get; set; }

        [Display(Name = "Address")]
        //[Required(ErrorMessage ="Enter Address")]
        public string Address { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<Doctor> Doctors { get; set; }
    }
}
