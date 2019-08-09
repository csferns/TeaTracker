using Microsoft.EntityFrameworkCore;
using System;

namespace TeaTracker.Data.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        DbContext CurrentContext();
        void Commit();
        IRepository<T> CreateRepository<T>() where T : class;
    }
}
