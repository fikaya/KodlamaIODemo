using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KodlamaIODemo.Entities.Models
{
    [Table("Courses")]
    public class Course : BaseClass
    {
        public Course()
        {
            CourseCategories = new List<CourseCategory>();
            CourseInstructors = new List<CourseInstructor>();
            CourseStudents = new List<CourseStudent>();
        }

        [Display(Name = "Kurs Başlığı", Prompt = "Lütfen Kurs Başlığını Giriniz.")]
        [Required(ErrorMessage = "{0} Alanı Boş Geçilemez")]
        [StringLength(maximumLength: 200, MinimumLength = 2, ErrorMessage = "{0} Alanı Max {1} ve Min {2} Karakter Olabilir.")]
        public string Title { get; set; }
        [Display(Name = "Kurs Açıklaması", Prompt = "Lütfen Kurs Açıklamasını Giriniz.")]
        [Required(ErrorMessage = "{0} Alanı Boş Geçilemez")]
        [StringLength(maximumLength: 200, MinimumLength = 2, ErrorMessage = "{0} Alanı Max {1} ve Min {2} Karakter Olabilir.")]
        public string Description { get; set; }
        [Display(Name = "Kurs Resmi", Prompt = "Lütfen Kurs Resmini Yükleyiniz.")]
        [Required(ErrorMessage = "{0} Alanı Boş Geçilemez")]
        [StringLength(maximumLength: 200, MinimumLength = 2, ErrorMessage = "{0} Alanı Max {1} ve Min {2} Karakter Olabilir.")]
        public string ImagePath { get; set; }
        public CourseTypes CourseType { get; set; }
        public List<CourseCategory> CourseCategories { get; set; }
        public List<CourseInstructor> CourseInstructors { get; set; }
        public List<CourseStudent> CourseStudents { get; set; }
    }
}
