using Dapper;
using KodlamaIODemo.DataAccess.Abstract.GeneralRepository;
using KodlamaIODemo.DataAccess.Concrete.DatabaseContext;
using KodlamaIODemo.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace KodlamaIODemo.DataAccess.Concrete.GeneralRepository.Dapper
{
    public class GetByID<T, U> : DbContextSetting<T, U>, IGetById<T>
    where T : BaseClass, new()
    where U : DbContext, new()
    {
        T IGetById<T>.GetById(int id)
        {
            using (DatabaseConnection)
            {
                var query = $"Select * From {typeof(T).Name} WHERE Id = @Id";
                return DatabaseConnection.QueryFirstOrDefault<T>(query, new { Id = id });
            }
        }
    }
}
