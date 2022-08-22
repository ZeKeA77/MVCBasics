using Microsoft.AspNetCore.Mvc;

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


        [HttpPost] //Get the Guess from the guest and compare to the session
        public IActionResult GuessGame(int txtGuess)
        {
            string guessMessage;

            if (txtGuess > HttpContext.Session.GetInt32("GuessSession"))
            {
                guessMessage = "Sorry, your guess of " + txtGuess + " is to high!";
            }

            else if (txtGuess == HttpContext.Session.GetInt32("GuessSession"))
            {
                guessMessage = "YES!!! " + txtGuess + " is the right number!";
                CreateSession();
            }

            else
            {
                guessMessage = "Sorry, your guess of " + txtGuess + " is to low!";
            }

            ViewBag.guessMessage = guessMessage;

            return View();
        }

        // Create new Session
        public void CreateSession()
        {
            var rand = new Random();
            int number = rand.Next(0, 100);
            HttpContext.Session.SetInt32("GuessSession", number);
        }
    }
}
