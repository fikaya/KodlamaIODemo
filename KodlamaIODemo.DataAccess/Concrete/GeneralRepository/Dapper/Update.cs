using System.Data;
using Dapper;
using KodlamaIODemo.DataAccess.Abstract.GeneralRepository;
using KodlamaIODemo.DataAccess.Concrete.DatabaseContext;
using KodlamaIODemo.Entities.Models;
using Microsoft.EntityFrameworkCore;
using static Dapper.SqlMapper;

namespace KodlamaIODemo.DataAccess.Concrete.GeneralRepository.Dapper
{
    public class Update<T, U> : DbContextSetting<T, U>, IUpdate<T>
    where T : BaseClass, new()
    where U : DbContext, new()
    {
        int IUpdate<T>.Update(T model)
        {
            using (DatabaseConnection)
            {
                var tableName = typeof(T).Name;

                var properties = typeof(T).GetProperties()
                    .Where(p => !p.Name.Equals("Id"))
                    .Select(p => $"{p.Name} = @{p.Name}");

                var query = $"Update {tableName} Set {string.Join(",", properties)} Where Id = @Id";

                return DatabaseConnection.Execute(query, model);
            }
        }
    }
}
