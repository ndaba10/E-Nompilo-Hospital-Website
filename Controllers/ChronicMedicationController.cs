using Microsoft.AspNetCore.Mvc;
using PHCApplication.Data;
using PHCApplication.Models;

namespace PHCApplication.Controllers
{
    public class ChronicMedicationController : Controller
    {
        private readonly PHCApplicationDbContext _context;
        public ChronicMedicationController(PHCApplicationDbContext context)
        {
            _context = context;
        }
        //Doctor appointments
        public IActionResult Index()
        {
            return View();
        }
        //Doctor examinations
		public IActionResult Examination()
		{
			return View();
		}
        //Doctor current patients
		public IActionResult Current()
		{

			return View();
		}
        //Pharmacist prescription
		public IActionResult Prescription()
		{
			return View();
		}
		//Pharmacist Reports
		public IActionResult Storage()
		{
			return View();
		}
		//Patient booking
		public IActionResult Booking()
		{
			return View();
		}
		//Patient medical book
		public IActionResult MedicalBook()
		{
			return View();
		}
		//View collections
		public IActionResult Collections()
		{
			return View();
		}
	}
}
