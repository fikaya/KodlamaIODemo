namespace KodlamaIODemo.DataAccess.Abstract.GeneralRepository
{
    public interface IUpdate<TEntity>
    where TEntity : class, new()
    {
        int Update(TEntity model);
    }
}
