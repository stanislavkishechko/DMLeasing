using BL.Common.Extentions;
using BL.Common.Interfaces.Services;
using Core.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.Controllers
{
    [Area("Admin")]
    public class ServiceItemsController : Controller
    {
        private readonly IServiceItemService _serviceItemService;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public ServiceItemsController(IWebHostEnvironment webHostEnvironment, IServiceItemService serviceItemService)
        {
            _webHostEnvironment = webHostEnvironment;
            _serviceItemService = serviceItemService;
        }

        public IActionResult Create(ServiceItem model, IFormFile titleImageFile)
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
                _serviceItemService.AddServiceItem(model);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
            return View(model);
           
        }

        public IActionResult Edit(Guid id)
        {
            var entity = id == default ? new ServiceItem() : _serviceItemService.GetServiceItemById(id);
            return View(entity);
        }

        [HttpPost]
        public IActionResult Edit(ServiceItem model, IFormFile titleImageFile)
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
                _serviceItemService.UpdateServiceItem(model);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            _serviceItemService.DeleteServiceItem(id);
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
        }
    }
}
