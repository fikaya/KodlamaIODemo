namespace KodlamaIODemo.DataAccess.Abstract.CourseRepository
{
    public interface IGetAllWithRelationship<TInformationDTO>
    where TInformationDTO : class, new()
    {
        IEnumerable<TInformationDTO> GetAllWithRelationship();
    }
}
