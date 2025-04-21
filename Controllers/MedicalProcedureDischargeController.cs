using Microsoft.AspNetCore.Mvc;
using PHCApplication.Data;

namespace PHCApplication.Controllers
{
    public class MedicalProcedureDischargeController : Controller
    {
        private readonly PHCApplicationDbContext _context;
        //ApplicationDbContext class so that it can access the database and perform create,read,update and delete,  operations for the "Fighters" entity.
        public MedicalProcedureDischargeController(PHCApplicationDbContext Db)
        {
            _context = Db;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
