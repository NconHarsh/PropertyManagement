using PropertyManagement.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManagement.Repository
{
   public interface IRepository<T> where T  : class
    {
        T GetById(Object id);

        void InsertRecord(T entity);

        void UpdateRecord(T entity);

        void Delete(object id);

        IEnumerable<T> Getall();
        
    }
}
