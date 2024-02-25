using KodlamaIODemo.DataAccess.Abstract.GeneralRepository;

namespace KodlamaIODemo.DataAccess.Abstract.Category
{
    public interface IStudentRepository<TEntity> : IAdd<TEntity>, IGetAll<TEntity>, IGetById<TEntity>, IRemove<TEntity>, IUpdate<TEntity>
    where TEntity : class, new()
    { }
}
