using System.ComponentModel.DataAnnotations;

namespace PHCApplication.Models
{
    public class PatientDoctor
    {
        [Key]
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
        
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
    }
}
