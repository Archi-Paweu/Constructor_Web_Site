using System.Net;
using System.Net.Mail;

namespace ConstructionPrototype.Models.Email
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string message)
        {
            var mail = "p.s.wisniewski@gmail.com";
            var pw = "test123";

            var client = new SmtpClient("raptorpl@o2.pl", 993)
            {
                EnableSsl = true,
                Credentials = new NetworkCredential(mail, pw)
            };

            return client.SendMailAsync(
                new MailMessage(from: mail,
                                to: email,
                                subject,
                                message));

        }
    }
}
