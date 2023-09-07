using BL.Common.Interfaces.Repositories;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Database.Repositories
{
    public class ServiceItemRepository : Repository<ServiceItem>, IServiceItemRepository
    {
        private readonly DbSet<ServiceItem> _dbSet;
        public ServiceItemRepository(AppDbContext dbContext) : base(dbContext)
        {
            _dbSet = dbContext.Set<ServiceItem>();
        }

        public IEnumerable<ServiceItem> GetServiceItemsByState(string state)
        {
            return _dbSet.Where(e => e.State == state);
        }
    }
}
