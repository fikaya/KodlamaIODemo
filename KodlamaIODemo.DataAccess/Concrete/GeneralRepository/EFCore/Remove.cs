using KodlamaIODemo.DataAccess.Abstract.GeneralRepository;
using KodlamaIODemo.DataAccess.Concrete.DatabaseContext;
using KodlamaIODemo.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace KodlamaIODemo.DataAccess.Concrete.GeneralRepository.EFCore
{
    public class Remove<T, U> : DbContextSetting<T, U>, IRemove<T>
    where T : BaseClass, new()
    where U : DbContext, new()
    {
        private IGetById<T> _getById;
        
        public Remove(IGetById<T> getById)
        {
            _getById = getById;
        }

        int IRemove<T>.Remove(T model)
        {
            var entity = _getById.GetById(model.Id);
            if (entity != null)
            {
                ObjectSet.Remove(entity);
                return DbContext.SaveChanges();
            }
            return 0;
        }
    }
}
