using KodlamaIODemo.DataAccess.Abstract.GeneralRepository;
using KodlamaIODemo.DataAccess.Abstract.InstructorRepository;

namespace KodlamaIODemo.DataAccess.Concrete.InstructorRepository
{
    public class InstructorRepository<T> : IInstructorRepository<T>
    where T : class, new()
    {
        private IAdd<T> _add;
        private IGetAll<T> _getAll;
        private IGetById<T> _getById;
        private IRemove<T> _remove;
        private IUpdate<T> _update;

        public InstructorRepository(IAdd<T> add, IGetAll<T> getAll, IGetById<T> getById, IRemove<T> remove, IUpdate<T> update)
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
