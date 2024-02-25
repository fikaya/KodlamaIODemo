using AutoMapper;
using KodlamaIODemo.Business.Abstract;
using KodlamaIODemo.DataAccess.Abstract.CourseRepository;

namespace KodlamaIODemo.Business.Concrete
{
    public class CourseService<TEntity, TInformationDTO> : ICourseService<TEntity, TInformationDTO>
    where TEntity : class, new()
    where TInformationDTO : class, new()
    {
        private ICourseRepository<TEntity, TInformationDTO> _courseRepository;
        private readonly IMapper _mapper;

        public CourseService(ICourseRepository<TEntity, TInformationDTO> courseRepository, IMapper mapper)
        {
            _courseRepository = courseRepository;
            _mapper = mapper;
        }

        public IEnumerable<TInformationDTO> GetAllWithRelationship()
        {
            var tInformationDTO = _courseRepository.GetAllWithRelationship();

            return tInformationDTO;
        }
        public IEnumerable<TEntity> GetAll()
        {
            return _courseRepository.GetAll();
        }

        public TEntity GetById(int id)
        {
            return _courseRepository.GetById(id);
        }

        public int Insert(TEntity model)
        {
            return _courseRepository.Add(model);
        }

        public int Update(TEntity model)
        {
            return _courseRepository.Update(model);
        }

        public int Delete(TEntity model)
        {
            return _courseRepository.Remove(model);
        }
    }
}
