using BL.Common.Interfaces.Repositories;
using BL.Common.Interfaces.Services;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Services
{
    public class BlogItemService : IBlogItemService
    {
        private readonly IRepository<BlogItem> _blogItemRepository;

        public BlogItemService(IRepository<BlogItem> blogItemRepository)
        {
            _blogItemRepository = blogItemRepository;
        }

        public IEnumerable<BlogItem> GetBlogItems()
        {
            return _blogItemRepository.GetAll();
        }

        public BlogItem GetBlogItemById(Guid id)
        {
            return _blogItemRepository.GetById(id);
        }

        public void DeleteBlogItem(Guid id)
        {
            _blogItemRepository.Delete(id);
        }

        public void AddBlogItem(BlogItem entity)
        {       
            _blogItemRepository.Insert(entity);
            _blogItemRepository.Save();
        }

        public void UpdateBlogItem(BlogItem entity)
        {
            _blogItemRepository.Update(entity);
            _blogItemRepository.Save();
        }
    }
}
