

using System.ComponentModel.DataAnnotations;

namespace PHCApplication.Models
{
    public class ProcedureEquipment
    {
        [Key]
        public int ProcedureId { get; set; }
        public Procedure Procedure { get; set; }
        
        public int EquipmentId { get; set; }
        public Equipment Equipment { get; set; }
    }
}
