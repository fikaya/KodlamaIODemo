using KodlamaIODemo.DataAccess.Abstract.GeneralRepository;
using KodlamaIODemo.DataAccess.Concrete.DatabaseContext;
using KodlamaIODemo.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace KodlamaIODemo.DataAccess.Concrete.GeneralRepository.EFCore
{
    public class GetByID<T, U> : DbContextSetting<T, U>, IGetById<T>
    where T : BaseClass, new()
    where U : DbContext, new()
    {
        T IGetById<T>.GetById(int id)
        {
            return ObjectSet.Find(id);
        }
    }
}
