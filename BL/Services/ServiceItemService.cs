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
    public class ServiceItemService : IServiceItemService
    {
        private readonly IServiceItemRepository _serviceItemRepository;

        public ServiceItemService(IServiceItemRepository serviceItemRepository)
        {
            _serviceItemRepository = serviceItemRepository;
        }

        public ServiceItem GetServiceItemById(Guid id)
        {
            return _serviceItemRepository.GetById(id);
        }

        public IEnumerable<ServiceItem> GetServiceItems()
        {
            return _serviceItemRepository.GetAll();
        }

        public void AddServiceItem(ServiceItem entity)
        {
            _serviceItemRepository.Insert(entity);
            _serviceItemRepository.Save();
        }

        public void DeleteServiceItem(Guid id)
        {
            _serviceItemRepository.Delete(id);
            _serviceItemRepository.Save();
        }

        public IEnumerable<ServiceItem> GetServiceItemByState(string state)
        {
            return _serviceItemRepository.GetServiceItemsByState(state);
        }

        public void UpdateServiceItem(ServiceItem entity)
        {
            _serviceItemRepository.Update(entity);
            _serviceItemRepository.Save();
        }
    }
}
