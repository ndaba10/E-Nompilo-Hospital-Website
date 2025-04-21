using Microsoft.AspNetCore.Mvc;
using PHCApplication.Data;

namespace PHCApplication.Controllers
{
    public class BookingApprovalController : Controller
    {

      
			private readonly PHCApplicationDbContext _context;
			public BookingApprovalController(PHCApplicationDbContext context)
			{
				_context = context;
			}
			public IActionResult Index()
            {
                return View();
            }
        }
    }

