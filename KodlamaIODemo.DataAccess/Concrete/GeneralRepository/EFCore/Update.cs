using KodlamaIODemo.DataAccess.Abstract.GeneralRepository;
using KodlamaIODemo.DataAccess.Concrete.DatabaseContext;
using KodlamaIODemo.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace KodlamaIODemo.DataAccess.Concrete.GeneralRepository.EFCore
{
    public class Update<T, U> : DbContextSetting<T, U>, IUpdate<T>
    where T : BaseClass, new()
    where U : DbContext, new()
    {
        int IUpdate<T>.Update(T model)
        {
            ObjectSet.Update(model);
            return DbContext.SaveChanges();
        }
    }
}
