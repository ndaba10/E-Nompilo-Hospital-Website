using Microsoft.AspNetCore.Mvc;
using PHCApplication.Data;

namespace PHCApplication.Controllers
{
    public class MentalHealthpatientBookingController : Controller
    {
        private readonly PHCApplicationDbContext _context;
        public MentalHealthpatientBookingController(PHCApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
