using BL.Common.Interfaces.Services;
using Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly IServiceItemService _serviceItemService;
        private readonly IBlogItemService _blogItemService;

        public HomeController(IServiceItemService serviceItemService, IBlogItemService blogItemService)
        {
            _serviceItemService = serviceItemService;
            _blogItemService = blogItemService;
        }

        public IActionResult Index()
        {
            ViewModel myModel = new ViewModel();
            myModel.ServiceItems = _serviceItemService.GetServiceItems();
            myModel.BlogItems = _blogItemService.GetBlogItems();
            return View(myModel);
        }
    }
}
