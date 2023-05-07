using System.Net;
using System.Net.Mail;

namespace ConstructionPrototype.Models.Email
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string message)
        {
            var mail = "exemplacc777@gmail.com";
            var pw = "exemplacc77713245";

            var client = new SmtpClient("smtp.gmail.com", 465)
            {
                EnableSsl = true,
                Credentials = new NetworkCredential(mail, pw)
            };

            return client.SendMailAsync(
                new MailMessage(mail,
                                email,
                                subject,
                                message));
        }

    }


    public class EmailForm
    {
        public string Receiver { get; set; }

        public string Subject { get; set; }

        public string Message { get; set; }
    }

    public class EmailSenderViewModel
    {
        public string ControllerPath { get; set; }
        public string ActionPath { get; set; }

        public EmailForm CreateFormMail { get; set; }
    }
}
