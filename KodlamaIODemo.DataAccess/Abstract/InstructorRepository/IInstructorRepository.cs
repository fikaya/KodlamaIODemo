using KodlamaIODemo.DataAccess.Abstract.GeneralRepository;

namespace KodlamaIODemo.DataAccess.Abstract.InstructorRepository
{
    public interface IInstructorRepository<TEntity> : IAdd<TEntity>, IGetAll<TEntity>, IGetById<TEntity>, IRemove<TEntity>, IUpdate<TEntity>
    where TEntity : class, new()
    { }
}
