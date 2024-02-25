using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KodlamaIODemo.Entities.Models
{
    [Table("Categories")]
    public class Category : BaseClass
    {
        public Category()
        {
            CourseCategories = new List<CourseCategory>();
        }

        [Display(Name = "Kategori Adı", Prompt = "Lütfen Kategori Adını Giriniz.")]
        [Required(ErrorMessage = "{0} Alanı Boş Geçilemez")]
        [StringLength(maximumLength: 200, MinimumLength = 2, ErrorMessage = "{0} Alanı Max {1} ve Min {2} Karakter Olabilir.")]
        public string CategoryName { get; set; }
        public ICollection<CourseCategory> CourseCategories { get; }
    }
}
