using Microsoft.EntityFrameworkCore;
using System;
using TeaTracker.Data.Interfaces;

namespace TeaTracker.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Context context;

        public UnitOfWork(Context context)
        {
            this.context = context;
        }

        public DbContext CurrentContext()
        {
            return context;
        }

        public void Commit()
        {
            context.SaveChanges();
        }

        public IRepository<T> CreateRepository<T>() where T : class
        {
            return new Repository<T>(this);
        }

        public void Dispose()
        {
            if (this.context != null)
            {
                try
                {
                    this.context.Dispose();
                }
                catch
                {

                }
            }
            GC.SuppressFinalize(this);
        }
    }
}
