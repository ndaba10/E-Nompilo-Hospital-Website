using System.ComponentModel.DataAnnotations;

namespace PHCApplication.Models
{
    public class OrderVacc
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string VaccType { get; set; }
        [Required]
        public int Quamtity { get; set; }
        [Required]
        public string StorageRequi { get; set; }
        [Required]
        public DateTime deliveryDate { get; set; }
        [Required]
        public string Address { get; set; }
        public string AddressLine1 { get; set; }
    }
}
