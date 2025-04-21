using Microsoft.AspNetCore.Mvc;
using PHCApplication.Data;

namespace PHCApplication.Controllers
{
    public class MentalHealthPrescriptionController : Controller
    {
        private readonly PHCApplicationDbContext _context;
        public MentalHealthPrescriptionController(PHCApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
