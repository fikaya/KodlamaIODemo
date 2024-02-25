namespace KodlamaIODemo.DataAccess.Abstract.GeneralRepository
{
    public interface IRemove<TEntity>
    where TEntity : class, new()
    {
        int Remove(TEntity model);
    }
}
