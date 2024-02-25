using System.Data;
using KodlamaIODemo.Entities.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace KodlamaIODemo.DataAccess.Concrete.DatabaseContext
{
    public abstract class DbContextSetting<T, U>
    where T : BaseClass, new()
    where U : DbContext, new()
    {
        public DbContextSetting()
        {
            _objectSet = _dbContext.Set<T>();
            _databaseConnection = new SqlConnection(DbContext.Database.GetDbConnection().ConnectionString);
        }

        private readonly U _dbContext = new U();

        private DbSet<T> _objectSet;

        private IDbConnection _databaseConnection;

        public DbSet<T> ObjectSet => _objectSet;

        public U DbContext => _dbContext;

        public IDbConnection DatabaseConnection => _databaseConnection;

    }
}
