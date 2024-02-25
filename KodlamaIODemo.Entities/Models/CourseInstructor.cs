using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KodlamaIODemo.Entities.Models
{
    [Table("CourseInstructors")]
    public class CourseInstructor : BaseClass
    {
        [ForeignKey("Instructor")]
        public int InstructorId { get; set; }
        public virtual Instructor Instructor { get; set; }
        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
    }
}
