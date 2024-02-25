using Dapper;
using KodlamaIODemo.DataAccess.Abstract.GeneralRepository;
using KodlamaIODemo.DataAccess.Concrete.DatabaseContext;
using KodlamaIODemo.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace KodlamaIODemo.DataAccess.Concrete.GeneralRepository.Dapper
{
    public class GetAll<T, U> : DbContextSetting<T, U>, IGetAll<T>
    where T : BaseClass, new()
    where U : DbContext, new()
    {
        IEnumerable<T> IGetAll<T>.GetAll()
        {
            using (DatabaseConnection)
            {
                string query = "Select * From " + typeof(T).Name + "s";
                return DatabaseConnection.Query<T>(query);
            }
        }
    }
}