using BL.Common.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Web.ViewComponents
{
    public class BlogViewComponent : ViewComponent
    {
        private readonly IBlogItemService _blogItemService;

        public BlogViewComponent(IBlogItemService blogItemService)
        {
            _blogItemService = blogItemService;
        }

        public Task<IViewComponentResult> InvokeAsync()
        {
            return Task.FromResult((IViewComponentResult)View("Default", _blogItemService.GetBlogItems()));
        }
    }
}
