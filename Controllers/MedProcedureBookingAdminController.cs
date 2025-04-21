using Microsoft.AspNetCore.Mvc;
using PHCApplication.Data;

namespace PHCApplication.Controllers
{
    public class MedProcedureBookingAdminController : Controller
    {
        private readonly PHCApplicationDbContext _context;
        //ApplicationDbContext class so that it can access the database and perform create,read,update and delete,  operations for the "Fighters" entity.
        public MedProcedureBookingAdminController(PHCApplicationDbContext Db)
        {
            _context = Db;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
