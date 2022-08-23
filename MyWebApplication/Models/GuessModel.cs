namespace MyWebApplication.Models
{
    public class GuessModel
    {
        // Create new number to guess
        public static int CreateRandomNumber()
        {
            var rand = new Random();
            int number = rand.Next(0, 100);
            return number;
        }

        // Check and comunicate with the user
        public static string GuessGame(int txtGuess, int gSession)
        {
            string guessMessage;

            if (txtGuess > gSession)
            {
                guessMessage = "Sorry, your guess of " + txtGuess + " is to high!";
            }

            else if (txtGuess == gSession)
            {
                guessMessage = "YES!!! " + txtGuess + " is the right number!";
            }

            else
            {
                guessMessage = "Sorry, your guess of " + txtGuess + " is to low!";
            }

            return guessMessage;
        }

    }
}
