using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PHCApplication.Data;
using PHCApplication.Models;

namespace PHCApplication.Controllers
{
    public class RegVaccineController : Controller
    {
        private readonly PHCApplicationDbContext _context;
        //ApplicationDbContext class so that it can access the database and perform create,read,update and delete,  operations for the "Fighters" entity.
        public RegVaccineController(PHCApplicationDbContext Db)
        {
            _context = Db;
        }
        // GET: RegVaccine
        public ActionResult Index()
        {
            IEnumerable<GenCert> genCerts = _context.GenCert;
            return View(genCerts);
        }

        // GET: RegVaccine/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RegVaccine/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RegVaccine/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(GenCert genCert)
        {
           try
            {
                if (ModelState.IsValid)
                {
                    _context.GenCert.Add(genCert);
                    _context.SaveChanges();
                    TempData["SuccessMessage"] = "You have Successfully Generated  New Certificate";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["errorMessage"] = "Model data is not valid";
                    return View(genCert);
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: RegVaccine/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RegVaccine/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RegVaccine/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RegVaccine/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
