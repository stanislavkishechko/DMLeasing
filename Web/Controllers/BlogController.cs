using BL.Common.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogItemService _blogItemService;
        private readonly ITextFieldService _textFieldService;

        public BlogController(ITextFieldService textFieldService, IBlogItemService blogItemService)
        {
            _textFieldService = textFieldService;
            _blogItemService = blogItemService;
        }

        [HttpGet]
        public ActionResult Index(Guid id)
        {
            if (id != default)
            {
                return View("Show", _blogItemService.GetBlogItemById(id));
            }

            ViewBag.TextField = _textFieldService.GetTextFieldByCodeWord("PageBlog");
            return View(_blogItemService.GetBlogItems());
        }
    }
}
