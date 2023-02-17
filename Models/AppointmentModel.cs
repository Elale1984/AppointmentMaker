using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppointmentMaker.Models
{
    public class AppointmentModel
    {
        [Required]
        [StringLength(20, MinimumLength = 4)]
        [DisplayName("Patient's Full Name")]
        public string PatientName { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Appointment Request Date")]
        public DateTime AppointmentDate { get; set; }

        [DataType(DataType.Currency)]
        [Range(90000, int.MaxValue, ErrorMessage = "Doctors refuse to see patients unless their net worth is more than\r\n$90,000\"\r\n")]
        [DisplayName("Patient's Approximate Net Worth")]
        public decimal PatientNetWorth { get; set; }

        [DisplayName("Primary Doctor's Last Name")]
        public string DoctorName { get; set; }

        [Range(6, 10, ErrorMessage = "Doctors refuse to see patients unless their pain level is above a 5")]
        [DisplayName("Patient's Perceived Pain Level")]
        public int PainLevel { get; set; }

        [StringLength(40, MinimumLength = 5)]
        [DisplayName("Street Address")]
        public string Street { get; set; }

        [StringLength(30, MinimumLength = 1 )]
        [DisplayName("City")]
        public string City { get; set; }

        [StringLength(30, MinimumLength = 1)]
        [DisplayName("State")]
        public string State { get; set; }

        [StringLength(maximumLength:5, MinimumLength = 5)]
        [DisplayName("Zip Code")]
        public string Zip { get; set; }



        [Required(ErrorMessage = "Please Enter Email Address")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "You must provide a phone number")]
        [Display(Name = "Phone")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string PhoneNumber { get; set; }


    }
}
