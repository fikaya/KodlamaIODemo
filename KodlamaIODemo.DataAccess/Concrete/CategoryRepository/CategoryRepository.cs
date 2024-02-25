﻿using KodlamaIODemo.DataAccess.Abstract.CategoryRepository;
using KodlamaIODemo.DataAccess.Abstract.GeneralRepository;

namespace KodlamaIODemo.DataAccess.Concrete.CategoryRepository
{
    public class CategoryRepository<T> : ICourseCategoryRepository<T>
    where T : class, new()
    {
        private IAdd<T> _add;
        private IGetAll<T> _getAll;
        private IGetById<T> _getById;
        private IRemove<T> _remove;
        private IUpdate<T> _update;

        public CategoryRepository(IAdd<T> add, IGetAll<T> getAll, IGetById<T> getById, IRemove<T> remove, IUpdate<T> update)
        {
            _add = add;
            _getAll = getAll;
            _getById = getById;
            _remove = remove;
            _update = update;
        }

        public int Add(T model)
        {
            return _add.Add(model);
        }

        public IEnumerable<T> GetAll()
        {
            return _getAll.GetAll();
        }

        public T GetById(int id)
        {
            return _getById.GetById(id);
        }

        public int Remove(T model)
        {
            return _remove.Remove(model);
        }

        public int Update(T model)
        {
            return _update.Update(model);
        }
    }
}
