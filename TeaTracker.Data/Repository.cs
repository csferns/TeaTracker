using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TeaTracker.Data.Interfaces;

namespace TeaTracker.Data
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private DbContext context;
        public Repository(IUnitOfWork unitofwork)
        {
            context = unitofwork.CurrentContext();
        }

        public IEnumerable<T> GetAll()
        {
            return context.Set<T>().AsEnumerable();
        }

        public T GetById(int id)
        {
            return context.Set<T>().Find(id);
        }

        public IQueryable<T> GetQuery()
        {
            return context.Set<T>().AsQueryable();
        }

        public void Add(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            context.Set<T>().Add(entity);
            context.SaveChanges();
        }

        public virtual void Update(T entity)
        {
            context.Set<T>().Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            var entry = context.Entry(entity);
            if (entry.State != EntityState.Detached)
            {
                context.Set<T>().Remove(entity);
                context.SaveChanges();
            }
        }
    }
}
