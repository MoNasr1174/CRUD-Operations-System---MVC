using Demo.DAL.Models;
using System.Net.Mail;
using System.Net;

namespace Demo.PL.Helpers
{
    public static class EmailSetting
    {
        public static void SendMail(Email email)
        {
            var mailServer = new SmtpClient("smtp.gmail.com", 587);
            mailServer.EnableSsl = true;
            mailServer.Credentials = new NetworkCredential("mohamednasr117411@gmail.com", "ujqsfuzflocceivt");
            // ujqs fuzf locc eivt

            mailServer.Send("mohamednasr117411@gmail.com", email.To, email.Subject, email.Body);
        }
    }
}
