using ConstructionPrototype.Models.Email;
using Microsoft.AspNetCore.Mvc;

namespace ConstructionPrototype.Controllers
{
    public class EmailController : Controller
    {
        private readonly IEmailSender _emailSender;
        public EmailController(IEmailSender emailSender)
        {
            this._emailSender = emailSender;
        }

        [HttpGet]
        public IActionResult GetMailData([FromForm] EmailForm? CreateFormMail = null)
        {

            EmailSenderViewModel viewModel = new EmailSenderViewModel
            {
                CreateFormMail = CreateFormMail == null ? new EmailForm() : CreateFormMail,
                ActionPath = "SendEmail",
                ControllerPath = "Email"

            };
            return View(viewModel);
        }


        [HttpPost]
        public async Task<IActionResult> SendEmail([FromForm] EmailForm CreateFormMail)
        {

            await _emailSender.SendEmailAsync(CreateFormMail.Receiver, CreateFormMail.Subject, CreateFormMail.Message);

            return RedirectToAction("Contacts", "Service");
        }

    }
}
