using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace PHCApplication.Models
{
    public class Stock
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Medication name is required.")]
        [StringLength(100, ErrorMessage = "Medication name should not exceed 100 characters.")]
        public string Name { get; set; }

        [StringLength(200, ErrorMessage = "Stock should not exceed 200 characters.")]
        public string Description { get; set; }



        [Display(Name = "Available Quantity")]
        [Range(0, int.MaxValue, ErrorMessage = "Quantity must be a non-negative value.")]
        public int AvailableQuantity { get; set; }

        [Display(Name = "Reorder Level")]
        [Range(0, int.MaxValue, ErrorMessage = "Reorder level must be a non-negative value.")]
        public int ReorderLevel { get; set; }


    }
}
