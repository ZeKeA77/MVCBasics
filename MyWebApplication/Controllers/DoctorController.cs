using Microsoft.AspNetCore.Mvc;
using MyWebApplication.Models;

namespace MyWebApplication.Controllers
{
    public class DoctorController : Controller
    {
        public IActionResult FeverCheck()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FeverCheck(double txtTemp)
        {
            ViewBag.TempMessage = DoctorModel.FeverCheck(txtTemp);

            return View();
        }
    }
}
