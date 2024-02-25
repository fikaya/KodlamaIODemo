namespace KodlamaIODemo.DataAccess.Abstract.GeneralRepository
{
    public interface IGetById<TEntity>
    where TEntity : class, new()
    {
        TEntity GetById(int id);
    }
}
