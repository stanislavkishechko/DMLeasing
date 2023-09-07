using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Common.Interfaces.Services
{
    public interface IServiceItemService
    {
        ServiceItem GetServiceItemById(Guid id);
        IEnumerable<ServiceItem> GetServiceItems();
        IEnumerable<ServiceItem> GetServiceItemByState(string state);
        void AddServiceItem(ServiceItem entity);
        void UpdateServiceItem(ServiceItem entity);
        void DeleteServiceItem(Guid id);
    }
}
