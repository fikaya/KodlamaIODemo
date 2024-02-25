using KodlamaIODemo.DataAccess.Abstract.GeneralRepository;

namespace KodlamaIODemo.DataAccess.Abstract.CourseCategoryRepository
{
    public interface ICourseCategoryRepository<TEntity> : IAdd<TEntity>, IGetAll<TEntity>, IGetById<TEntity>, IRemove<TEntity>, IUpdate<TEntity>
    where TEntity : class, new()
    { }
}
