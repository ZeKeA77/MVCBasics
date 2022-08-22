namespace MyWebApplication.Models
{
    public class DoctorModel
    {
        public static string FeverCheck(double txtTemp)
        {
            var tempMessage = "";


            if (txtTemp >= 37.8)
            {
                tempMessage = "Sorry, but it feels like " + txtTemp + " is a little to hot! You have a fever, get a cold shower!";
            }
            else if (txtTemp <= 36.0)
            {
                tempMessage = "Your body temperature of " + txtTemp + " is way too low,put on a cote!";
            }
            else
            {
                tempMessage = "Your body temperature of " + txtTemp + " is within reasonable limits, you are neither too hot nor too cold!";
            }

            return tempMessage;

        }

    }
}
