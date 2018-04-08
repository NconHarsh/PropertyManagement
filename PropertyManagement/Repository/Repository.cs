using PropertyManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PropertyManagement.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private nconin_PropertyUATEntities _propertyentity;
        private DbSet<T> dbset;

        public Repository()
        {
            _propertyentity = new nconin_PropertyUATEntities();
            dbset = _propertyentity.Set<T>();
        }
        public void Save()
        {
            _propertyentity.SaveChanges();
        }

        public void Delete(object id)
        {
            T entityobject = dbset.Find(id);
            dbset.Remove(entityobject);
        }

        public IEnumerable<T> Getall()
        {
           return  dbset.ToList();
        }

        public T GetById(object id)
        {
            return dbset.Find(id);
        }

        public void InsertRecord(T entity)
        {
            dbset.Add(entity);
            Save();
        }

        public void UpdateRecord(T entity)
        {
            dbset.Attach(entity);
            _propertyentity.Entry(entity).State = System.Data.EntityState.Modified;
        }
    }
}