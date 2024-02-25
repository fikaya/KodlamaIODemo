namespace KodlamaIODemo.DataAccess.Abstract.GeneralRepository
{
    public interface IAdd<TEntity>
    where TEntity : class, new()
    {
        int Add(TEntity model);
    }
}
