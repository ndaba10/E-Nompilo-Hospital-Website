using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PHCApplication.Data;
using PHCApplication.Models;

namespace PHCApplication.Controllers
{
    public class PrenatalController : Controller
    {
        private readonly PHCApplicationDbContext dbContext;
        public PrenatalController(PHCApplicationDbContext dBD)
        {
            dbContext = dBD;
        }

        public IActionResult Index()
        {
            IEnumerable<PrenatalAppointment> objList = dbContext.PrenatalApp;
            return View(objList);
        }

        public IActionResult RequestAppointment(PrenatalAppointment app)
        {

            if (ModelState.IsValid)
            {
                dbContext.PrenatalApp.Add(app);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(app);
        }

        public IActionResult AppointmentList()
        {
            return View();
        }

        public IActionResult AddComplaint()
        {
            return View();
        }

        public IActionResult RequestAmbulance()
        {
            return View();
        }

        public IActionResult ViewPrescriptions()
        {
            return View();
        }

        public IActionResult LodgeComplaint()
        {
            return View();
        }

        public IActionResult AvailableDoctors()
        {
            return View();
        }
    }
}
