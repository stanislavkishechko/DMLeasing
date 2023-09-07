using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class ViewModel
    {
        public IEnumerable<ServiceItem> ServiceItems { get; set; }
        public IEnumerable<BlogItem> BlogItems { get; set; }
    }
}
