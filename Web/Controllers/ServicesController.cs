using BL.Common.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class ServicesController : Controller
    {
        private readonly IServiceItemService _serviceItemService;
        private readonly ITextFieldService _textFieldService;

        public ServicesController(ITextFieldService textFieldService, IServiceItemService serviceItemService)
        {
            _textFieldService = textFieldService;
            _serviceItemService = serviceItemService;
        }

        public IActionResult NewCars(Guid id)
        {
            if (id != default)
            {
                return View("Show", _serviceItemService.GetServiceItemById(id));
            }

            ViewBag.TextField = _textFieldService.GetTextFieldByCodeWord("PageServices");
            return View(_serviceItemService.GetServiceItemByState("New"));
        }

        public IActionResult UsedCars(Guid id)
        {
            if (id != default)
            {
                return View("Show", _serviceItemService.GetServiceItemById(id));
            }

            ViewBag.TextField = _textFieldService.GetTextFieldByCodeWord("PageServices");
            return View(_serviceItemService.GetServiceItemByState("Used"));
        }
    }
}
