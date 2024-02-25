using Dapper;
using KodlamaIODemo.DataAccess.Abstract.GeneralRepository;
using KodlamaIODemo.DataAccess.Concrete.DatabaseContext;
using KodlamaIODemo.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace KodlamaIODemo.DataAccess.Concrete.GeneralRepository.Dapper
{
    public class Remove<T, U> : DbContextSetting<T, U>, IRemove<T>
    where T : BaseClass, new()
    where U : DbContext, new()
    {
        int IRemove<T>.Remove(T model)
        {

            using (DatabaseConnection)
            {
                var tableName = typeof(T).Name;

                var query = $"Delete From {tableName} Where Id = @Id";

                return DatabaseConnection.Execute(query, model);
            }
        }
    }
}
