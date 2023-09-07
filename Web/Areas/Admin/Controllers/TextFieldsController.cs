using BL.Common.Extentions;
using BL.Common.Interfaces.Services;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.Controllers
{
    [Area("Admin")]
    public class TextFieldsController : Controller
    {
        private readonly ITextFieldService _textFieldService;

        public TextFieldsController(ITextFieldService textFieldService)
        {
            _textFieldService = textFieldService;
        }

        public IActionResult Edit(string codeWord)
        {
            _textFieldService.GetTextFieldByCodeWord(codeWord);
            return View();
        }

        [HttpPost]
        public IActionResult Edit(TextField model)
        {
            if (ModelState.IsValid)
            {
                _textFieldService.AddTextField(model);
                _textFieldService.UpdateTextField(model);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
            return View(model);
        }
    }
}
