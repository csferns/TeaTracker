using TeaTracker.Data.Interfaces;

namespace TeaTracker.Core.BusinessLayer
{
    public class BaseBL<TEntity> : IBaseBL<TEntity> where TEntity : class
    {
        private IUnitOfWork unitOfWork;

        public BaseBL(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void Add(TEntity entity)
        {
            var repository = unitOfWork.CreateRepository<TEntity>();
            repository.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            var repository = unitOfWork.CreateRepository<TEntity>();
            repository.Delete(entity);
        }

        public void Update(TEntity entity)
        {
            var repository = unitOfWork.CreateRepository<TEntity>();
            repository.Update(entity);
        }
    }
}
