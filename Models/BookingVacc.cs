using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace PHCApplication.Models
{
    public class BookingVacc
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string StreetAddress { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string PostalAddress { get; set; }
        [Required]
        public string VaccinationType { get; set; }
        [Required]
        public string ContactNumber { get; set; }


        [Required(ErrorMessage = "Date of Vaccination is required.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date of Birth")]
        public DateTime DateOfVaccination { get; set; }
        [Required]
        public string Gender { get; set; }

    }
}
