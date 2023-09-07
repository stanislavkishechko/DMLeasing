using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BL.Common.Interfaces.Repositories
{
    public interface IRepository<T>
    {
        T GetById(Guid id);
        IEnumerable<T> GetAll();
        void Insert(T entity);
        void Update(T entity);
        void Save();
        void Delete(Guid id);
        void Delete(T entity);
    }
}
