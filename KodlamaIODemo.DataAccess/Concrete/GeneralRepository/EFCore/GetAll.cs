using KodlamaIODemo.DataAccess.Abstract.GeneralRepository;
using KodlamaIODemo.DataAccess.Concrete.DatabaseContext;
using KodlamaIODemo.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace KodlamaIODemo.DataAccess.Concrete.GeneralRepository.EFCore
{
    public class GetAll<T, U> : DbContextSetting<T, U>, IGetAll<T>
    where T : BaseClass, new()
    where U : DbContext, new()
    {
        IEnumerable<T> IGetAll<T>.GetAll()
        {
            return ObjectSet.ToList();
        }
    }
}
