namespace TeaTracker.Core.BusinessLayer
{
    public interface IBaseBL<TEntity> where TEntity : class
    {
        void Update(TEntity entity);
        void Add(TEntity entity);
        void Delete(TEntity entity);
    }
}
