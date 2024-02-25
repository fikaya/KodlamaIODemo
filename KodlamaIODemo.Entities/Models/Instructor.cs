using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KodlamaIODemo.Entities.Models
{
    [Table("Instructors")]
    public class Instructor : BaseClass
    {
        public Instructor()
        {
            CourseInstructors = new List<CourseInstructor>();
        }

        [Display(Name = "Eğitmen Adı", Prompt = "Lütfen Eğitmen Adını Giriniz.")]
        [Required(ErrorMessage = "{0} Alanı Boş Geçilemez")]
        [StringLength(maximumLength: 200, MinimumLength = 2, ErrorMessage = "{0} Alanı Max {1} ve Min {2} Karakter Olabilir.")]
        public string FirstName { get; set; }
        [Display(Name = "Eğitmen Soyadı", Prompt = "Lütfen Eğitmen Soyadını Giriniz.")]
        [Required(ErrorMessage = "{0} Alanı Boş Geçilemez")]
        [StringLength(maximumLength: 200, MinimumLength = 2, ErrorMessage = "{0} Alanı Max {1} ve Min {2} Karakter Olabilir.")]
        public string LastName { get; set; }
        public string FullName => FirstName + " " + LastName;
        [Display(Name = "Kurs Resmi", Prompt = "Lütfen Kurs Resmini Yükleyiniz.")]
        [Required(ErrorMessage = "{0} Alanı Boş Geçilemez")]
        [StringLength(maximumLength: 200, MinimumLength = 2, ErrorMessage = "{0} Alanı Max {1} ve Min {2} Karakter Olabilir.")]
        public string ImagePath { get; set; }
        public ICollection<CourseInstructor> CourseInstructors { get; }
    }
}
