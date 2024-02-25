using KodlamaIODemo.Entities.Models;

namespace KodlamaIODemo.Entities.DTO.Course
{
    public class CourseInformationDTO : BaseClass
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public CourseTypes CourseType { get; set; }
        public int InstructorId { get; set; }
        public string InstructorImagePath { get; set; }
        public string InstructorFirstName { get; set; }
        public string InstructorLastName { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
