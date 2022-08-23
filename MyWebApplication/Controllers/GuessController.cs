using Microsoft.AspNetCore.Mvc;
using MyWebApplication.Models;

namespace MyWebApplication.Controllers
{
    public class GuessController : Controller
    {
        //Check if Session exists, else create a new session
        public IActionResult GuessGame()
        {
            if (HttpContext.Session.GetString("GuessSession") == null)
            {
                CreateSession();
            }

            return View();
        }

        //Create/remove Session
        public void CreateSession()
        {
            HttpContext.Session.Remove("GuessSession");
            HttpContext.Session.SetString("GuessSession", Convert.ToString(GuessModel.CreateRandomNumber()));
        }

        //Get the Guess from the guest and compare to the session
        [HttpPost]
        public IActionResult GuessGame(int txtGuess, int gSession)
        {
            gSession = Convert.ToInt32(HttpContext.Session.GetString("GuessSession"));

            ViewBag.guessMessage = GuessModel.GuessGame(txtGuess, gSession);

            if (txtGuess == gSession)
            {
                CreateSession();
            }

            return View();
        }

    }
}
