using System.ComponentModel.DataAnnotations;

namespace PHCApplication.Models
{
    public class Discharge
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "First Name is required.")]
        [RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "The name field can only contain letters.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 50 characters")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "Last Name is required.")]
        [RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "The name field can only contain letters.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 50 characters")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Discharge date is required.")]
        [Display(Name = "Check in Date")]
        [DataType(DataType.Date)]
        public DateTime CheckIn { get; set; }

        [Required(ErrorMessage = "Discharge date is required.")]
        [Display(Name = "Discharge Date")]
        [DataType(DataType.Date)]
        public DateTime DischargeDate { get; set; }

        [StringLength(500, ErrorMessage = "Discharge summary should not exceed 500 characters.")]
        [Display(Name = "Discharge Summary")]
        public string Summary { get; set; }

     
    }
}

