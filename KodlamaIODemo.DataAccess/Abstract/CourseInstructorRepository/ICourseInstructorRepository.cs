using KodlamaIODemo.DataAccess.Abstract.GeneralRepository;

namespace KodlamaIODemo.DataAccess.Abstract.CourseInstructorRepository
{
    public interface ICourseInstructorRepository<TEntity> : IAdd<TEntity>, IGetAll<TEntity>, IGetById<TEntity>, IRemove<TEntity>, IUpdate<TEntity>
    where TEntity : class, new()
    { }
}
