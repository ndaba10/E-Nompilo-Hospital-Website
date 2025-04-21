using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PHCApplication.Data;
using PHCApplication.Models;

namespace PHCApplication.Controllers
{
    public class VaccPatientRegister : Controller
    {
        private readonly PHCApplicationDbContext dbContext;
        public VaccPatientRegister(PHCApplicationDbContext dBD)
        {
            dbContext = dBD;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Registering registering)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    dbContext.Registerin.Add(registering);
                    dbContext.SaveChanges();
                    TempData["SuccessMessage"] = "You have Successfully booked!";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["errorMessage"] = "Model data is not valid";
                    return View(registering);
                }
            }
            catch (Exception ex)
            {

                TempData["errorMessage"] = ex.Message;
                return View(registering);
            }
        }
        public IActionResult Viewing()
        {
            return View();
        }
    }
}
