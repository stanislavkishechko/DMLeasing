using BL.Common.Extentions;
using BL.Common.Interfaces.Services;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Web.Controllers;

namespace Web.Areas.Controllers
{
    [Area("Admin")]
    public class BlogItemsController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IBlogItemService _blogItemService;
        public BlogItemsController(IWebHostEnvironment webHostEnvironment, IBlogItemService blogItemService)
        {
            _webHostEnvironment = webHostEnvironment;
            _blogItemService = blogItemService;
        }

        public IActionResult Edit(Guid id)
        {
            var entity = id == default ? new BlogItem() : _blogItemService.GetBlogItemById(id);
            return View(entity);
        }


        [HttpPost]
        public IActionResult Edit(BlogItem model, IFormFile titleImageFile)
        {
            if (ModelState.IsValid)
            {
                if (titleImageFile != null)
                {
                    model.TitleImagePath = titleImageFile.FileName;
                    using (var stream = new FileStream(Path.Combine(_webHostEnvironment.WebRootPath, "images/", titleImageFile.FileName), FileMode.Create))
                    {
                        titleImageFile.CopyTo(stream);
                    }
                }
                _blogItemService.AddBlogItem(model);
                _blogItemService.UpdateBlogItem(model);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(Guid id)
        {
           _blogItemService.DeleteBlogItem(id);
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
        }
    }
}
