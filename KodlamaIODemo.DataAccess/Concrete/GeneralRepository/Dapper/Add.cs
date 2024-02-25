using System.Data;
using Dapper;
using KodlamaIODemo.DataAccess.Abstract.GeneralRepository;
using KodlamaIODemo.DataAccess.Concrete.DatabaseContext;
using KodlamaIODemo.Entities.Models;
using Microsoft.EntityFrameworkCore;
using static Dapper.SqlMapper;

namespace KodlamaIODemo.DataAccess.Concrete.GeneralRepository.Dapper
{
    public class Add<T, U> : DbContextSetting<T, U>, IAdd<T>
    where T : BaseClass, new()
    where U : DbContext, new()
    {
        int IAdd<T>.Add(T model)
        {
            using (DatabaseConnection)
            {
                var tableName = typeof(T).Name;
                var properties = string.Join(",", typeof(T).GetProperties().Select(p => p.Name));
                var parameters = string.Join(",", typeof(T).GetProperties().Select(p => "@" + p.Name));

                var query = $"Insert Into {tableName} ({properties}) Values ({parameters})";

                return DatabaseConnection.Execute(query, model);
            }
        }
    }
}
