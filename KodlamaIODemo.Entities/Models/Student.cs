using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KodlamaIODemo.Entities.Models
{
    [Table("Students")]
    public class Student : BaseClass
    {
        public Student()
        {
            StudentCourses = new List<CourseStudent>();
        }

        [Display(Name = "Öğrenci Adı", Prompt = "Lütfen Öğrenci Adını Giriniz.")]
        [Required(ErrorMessage = "{0} Alanı Boş Geçilemez")]
        [StringLength(maximumLength: 200, MinimumLength = 2, ErrorMessage = "{0} Alanı Max {1} ve Min {2} Karakter Olabilir.")]
        public string FirstName { get; set; }
        [Display(Name = "Öğrenci Soyadı", Prompt = "Lütfen Öğrenci Soyadı Giriniz.")]
        [Required(ErrorMessage = "{0} Alanı Boş Geçilemez")]
        [StringLength(maximumLength: 200, MinimumLength = 2, ErrorMessage = "{0} Alanı Max {1} ve Min {2} Karakter Olabilir.")]
        public string LastName { get; set; }
        public string FullName => FirstName + " " + LastName;
        [Display(Name = "Öğrenci Mai Adresi", Prompt = "Lütfen Öğrenci Mailini Giriniz.")]
        [Required(ErrorMessage = "{0} Alanı Boş Geçilemez")]
        [StringLength(maximumLength: 30, MinimumLength = 2, ErrorMessage = "{0} Alanı Max {1} ve Min {2} Karakter Olabilir.")]
        public string EMail { get; set; }
        [Display(Name = "Öğrenci Telefon Numarası", Prompt = "Lütfen Öğrenci Telefon Numarasını Giriniz.")]
        [Required(ErrorMessage = "{0} Alanı Boş Geçilemez")]
        [StringLength(maximumLength: 30, MinimumLength = 2, ErrorMessage = "{0} Alanı Max {1} ve Min {2} Karakter Olabilir.")]
        public string TelephoneNumber { get; set; }
        [Display(Name = "Kurs Resmi", Prompt = "Lütfen Kurs Resmini Yükleyiniz.")]
        [Required(ErrorMessage = "{0} Alanı Boş Geçilemez")]
        [StringLength(maximumLength: 200, MinimumLength = 2, ErrorMessage = "{0} Alanı Max {1} ve Min {2} Karakter Olabilir.")]
        public string ImagePath { get; set; }
        public ICollection<CourseStudent> StudentCourses { get; }
    }
}
