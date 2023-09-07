using BL.Common.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITextFieldService _textFieldService;
        public HomeController(ITextFieldService textFieldService)
        {
            _textFieldService = textFieldService;
        }

        public IActionResult Index()
        {           
            return View(_textFieldService.GetTextFieldByCodeWord("PageIndex"));
        }

        public IActionResult Finance()
        {
            return View(_textFieldService.GetTextFieldByCodeWord("PageFinance"));
        }

        public IActionResult LeaseVSBuy()
        {
            return View(_textFieldService.GetTextFieldByCodeWord("PageLeaseVSBuy"));
        }

        public IActionResult Dealers()
        {
            return View(_textFieldService.GetTextFieldByCodeWord("PageDealers"));
        }

        public IActionResult Partners()
        {
            return View(_textFieldService.GetTextFieldByCodeWord("PagePartners"));
        }

        public IActionResult Terms()
        {
            return View(_textFieldService.GetTextFieldByCodeWord("PageTerms"));
        }

        public IActionResult Privacy()
        {
            return View(_textFieldService.GetTextFieldByCodeWord("PagePrivacy"));
        }


    }
}
