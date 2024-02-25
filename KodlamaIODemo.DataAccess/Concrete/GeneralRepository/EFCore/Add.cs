using KodlamaIODemo.DataAccess.Abstract.GeneralRepository;
using KodlamaIODemo.DataAccess.Concrete.DatabaseContext;
using KodlamaIODemo.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace KodlamaIODemo.DataAccess.Concrete.GeneralRepository.EFCore
{
    public class Add<T, U> : DbContextSetting<T, U>, IAdd<T>
    where T : BaseClass, new()
    where U : DbContext, new()
    {
        int IAdd<T>.Add(T model)
        {
            ObjectSet.Add(model);
            return DbContext.SaveChanges();
        }
    }
}
