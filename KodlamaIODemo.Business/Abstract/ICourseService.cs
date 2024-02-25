namespace KodlamaIODemo.Business.Abstract
{
    public interface ICourseService<TEntity, TInformationDTO>
    where TEntity : class
    {
        IEnumerable<TInformationDTO> GetAllWithRelationship();
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
        int Insert(TEntity model);
        int Update(TEntity model);
        int Delete(TEntity model);

    }
}
