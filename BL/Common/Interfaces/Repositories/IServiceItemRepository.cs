using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Common.Interfaces.Repositories
{
    public interface IServiceItemRepository : IRepository<ServiceItem>
    {
        public IEnumerable<ServiceItem> GetServiceItemsByState(string state);
    }
}
