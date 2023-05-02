using ConstructionPrototype.Models;
using ConstructionPrototype.Models.Email;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ConstructionPrototype.Controllers
{
    public class EmailController : Controller
    {
        private readonly IEmailSender _emailSender;
        public EmailController(IEmailSender emailSender)
        {
            this._emailSender = emailSender;
        }

        public async Task<IActionResult> SendEmail()
        {
            var receiver = "";
            var subject = "";
            var message = "";

            await _emailSender.SendEmailAsync(receiver, subject, message);

            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
