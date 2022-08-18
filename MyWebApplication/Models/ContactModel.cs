namespace MyWebApplication.Models
{
    public class ContactModel
    {


        public string ContactForm(string txtName, string txtEmail, string txtMessage)
        {
            return txtName + txtEmail + txtMessage;
        }



    }
}
