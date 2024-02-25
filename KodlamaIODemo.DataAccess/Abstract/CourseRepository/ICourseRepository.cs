using KodlamaIODemo.DataAccess.Abstract.GeneralRepository;

namespace KodlamaIODemo.DataAccess.Abstract.CourseRepository
{
    public interface ICourseRepository<TEntity, TInformationDTO> : IAdd<TEntity>, IGetAll<TEntity>, IGetById<TEntity>, IRemove<TEntity>, IUpdate<TEntity>, IGetAllWithRelationship<TInformationDTO>
    where TEntity : class, new()
    where TInformationDTO : class, new()
    { }
}
