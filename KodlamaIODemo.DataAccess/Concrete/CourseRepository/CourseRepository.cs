using KodlamaIODemo.DataAccess.Abstract.CourseRepository;
using KodlamaIODemo.DataAccess.Abstract.GeneralRepository;

namespace KodlamaIODemo.DataAccess.Concrete.CourseRepository
{
    public class CourseRepository<TEntity, TInformationDTO> : ICourseRepository<TEntity, TInformationDTO>
    where TEntity : class, new()
    where TInformationDTO : class, new()
    {
        private IAdd<TEntity> _add;
        private IGetAllWithRelationship<TInformationDTO> _getAllWithRelationship;
        private IGetAll<TEntity> _getAll;
        private IGetById<TEntity> _getById;
        private IRemove<TEntity> _remove;
        private IUpdate<TEntity> _update;

        public CourseRepository(IAdd<TEntity> add, IGetAllWithRelationship<TInformationDTO> getAllWithRelationship, IGetAll<TEntity> getAll, IGetById<TEntity> getById, IRemove<TEntity> remove, IUpdate<TEntity> update)
        {
            _add = add;
            _getAllWithRelationship = getAllWithRelationship;
            _getAll = getAll;
            _getById = getById;
            _remove = remove;
            _update = update;
        }

        public int Add(TEntity model)
        {
            return _add.Add(model);
        }

        public IEnumerable<TInformationDTO> GetAllWithRelationship()
        {
            return _getAllWithRelationship.GetAllWithRelationship();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _getAll.GetAll();
        }


        public TEntity GetById(int id)
        {
            return _getById.GetById(id);
        }

        public int Remove(TEntity model)
        {
            return _remove.Remove(model);
        }

        public int Update(TEntity model)
        {
            return _update.Update(model);
        }
    }
}
