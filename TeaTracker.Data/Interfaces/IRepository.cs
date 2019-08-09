using System.Collections.Generic;
using System.Linq;

namespace TeaTracker.Data.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        IQueryable<T> GetQuery();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
