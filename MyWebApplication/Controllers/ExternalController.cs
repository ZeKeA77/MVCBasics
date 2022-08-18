using Microsoft.AspNetCore.Mvc;

namespace MyWebApplication.Controllers
{
    public class ExternalController : Controller
    {
        public IActionResult Projects()
        {
            return View();
        }
    }
}
