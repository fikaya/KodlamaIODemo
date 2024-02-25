using Dapper;
using KodlamaIODemo.DataAccess.Abstract.CourseRepository;
using KodlamaIODemo.DataAccess.Concrete.DatabaseContext;
using KodlamaIODemo.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace KodlamaIODemo.DataAccess.Concrete.CourseRepository.Dapper
{
    public class GetAllWithRelationship<TInformationDTO, U> : DbContextSetting<TInformationDTO, U>, IGetAllWithRelationship<TInformationDTO>
    where TInformationDTO : BaseClass, new()
    where U : DbContext, new()
    {
        IEnumerable<TInformationDTO> IGetAllWithRelationship<TInformationDTO>.GetAllWithRelationship()
        {
            using (DatabaseConnection)
            {
                string query = "Select\r\n'Id' = co.Id,\r\n'Title' = co.Title,\r\n'Description' = co.[Description],\r\n'ImagePath' = co.ImagePath,\r\n'CourseType' = co.CourseType,\r\n'InstructorId' = ins.Id,\r\n'InstructorImagePath' = ins.ImagePath,\r\n'InstructorFirstName' = ins.FirstName,\r\n'InstructorLastName' = ins.LastName,\r\n'CategoryId' = ca.Id,\r\n'CategoryName' = ca.CategoryName\r\nFrom Courses co\r\nInner Join CourseCategories as cc on cc.CourseId =co.Id\r\nInner Join CourseInstructors as ci on ci.CourseId=co.Id\r\nInner Join Categories as ca on ca.Id = cc.CategoryId  \r\nInner Join Instructors as ins on ins.Id = ci.InstructorId   ";
                return DatabaseConnection.Query<TInformationDTO>(query);
            }
        }
    }
}