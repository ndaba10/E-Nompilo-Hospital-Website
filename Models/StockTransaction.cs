using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace PHCApplication.Models
{
    public class StockTransaction
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Transaction date is required.")]
        [Display(Name = "Transaction Date")]
        [DataType(DataType.DateTime)]
        public DateTime TransactionDate { get; set; }


        [Required(ErrorMessage = "Quantity is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be a positive value.")]
        public int Quantity { get; set; }
        

        [Display(Name = "Transaction Type")]
        public TransactionType Type { get; set; }

       
    }
    public enum TransactionType
    {
        Purchase,
        Sale,
        Adjustment,
        Return
    }
}
