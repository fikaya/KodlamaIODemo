namespace KodlamaIODemo.DataAccess.Abstract.GeneralRepository
{
    public interface IGetAll<TEntity>
    where TEntity : class, new()
    {
        IEnumerable<TEntity> GetAll();
    }
}
