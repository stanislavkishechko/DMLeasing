using BL.Common.Extentions;
using BL.Common.Interfaces;
using BL.Common.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class ContactController : Controller
    {
        private readonly ITextFieldService _textFieldService;
        private readonly IEmailSender _emailSender;

        public ContactController(ITextFieldService textFieldService, IEmailSender emailSender)
        {
            _textFieldService = textFieldService;
            _emailSender = emailSender;
        }

        public IActionResult Index()
        {
            return View(_textFieldService.GetTextFieldByCodeWord("PageContacts"));
        }

        public IActionResult Send(string name, string email, string text)
        {
            _emailSender.SendEmail(name, email, text);

            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
        }

    }
}
