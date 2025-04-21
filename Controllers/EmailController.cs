
using Microsoft.AspNetCore.Mvc;
using PHCApplication.Models;

namespace PHCApplication.Controllers
{
    public class EmailController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Send()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Send(Email email )
        {
            email.SendMail();
            return View();
        }
    }
}
