using Microsoft.AspNetCore.Mvc;

namespace MyWebApplication.Controllers
{
    public class GuessingGameController : Controller
    {
        public IActionResult GuessGame()
        {
            return View();
        }
    }
}
