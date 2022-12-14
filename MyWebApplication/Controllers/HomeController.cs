using Microsoft.AspNetCore.Mvc;

namespace MyWebApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Projects()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(string txtName, string txtEmail, string txtMessage)
        {
            ViewBag.MessageName = "Your Name: " + txtName;
            ViewBag.MessageEmail = "Your E-mail: " + txtEmail;
            ViewBag.Message = "Your Message: " + txtMessage;
            return View();
        }

    }
}
