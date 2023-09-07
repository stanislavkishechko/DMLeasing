using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Common.Interfaces.Services
{
    public interface IBlogItemService
    {
        BlogItem GetBlogItemById(Guid id);
        IEnumerable<BlogItem> GetBlogItems();
        void AddBlogItem(BlogItem entity);
        void UpdateBlogItem(BlogItem entity);
        void DeleteBlogItem(Guid id);
    }
}
