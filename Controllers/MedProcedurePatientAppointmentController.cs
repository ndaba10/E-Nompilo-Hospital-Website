using Microsoft.AspNetCore.Mvc;
using PHCApplication.Data;
using PHCApplication.Models;

namespace PHCApplication.Controllers
{
	public class MedProcedurePatientAppointmentController : Controller
	{
		private readonly PHCApplicationDbContext _context;
		//ApplicationDbContext class so that it can access the database and perform create,read,update and delete,  operations for the "Fighters" entity.
		public MedProcedurePatientAppointmentController(PHCApplicationDbContext Db)
		{
			_context = Db;
		}
		public IActionResult Index()
		{
			IEnumerable<Appointment> appointments = _context.Appointment;
			return View(appointments);
		}
		[HttpGet]
		//Get method that returns the create.cshtml
		//The method returns a View called "Create" which is an HTML page that allows the user to enter details for a new record of the "Appointmts" entity.
		public IActionResult Create()
		{
			return View();
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Create(Appointment appointment)
		{
			try
			{
				if (ModelState.IsValid)
				{
					_context.Appointment.Add(appointment);
					_context.SaveChanges();
					TempData["SuccessMessage"] = "You have Successfully booked!";
					return RedirectToAction("Index");
				}
				else
				{
					TempData["errorMessage"] = "Model data is not valid";
					return View(appointment);
				}
			}
			catch (Exception ex)
			{

				TempData["errorMessage"] = ex.Message;
				return View(appointment);
			}

		}
	}
}
