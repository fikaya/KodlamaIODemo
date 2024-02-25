using KodlamaIODemo.Business.Abstract;
using KodlamaIODemo.Entities.DTO.Course;
using KodlamaIODemo.Entities.Models;
using Microsoft.AspNetCore.Mvc;

namespace KodlamaIODemo.Presentation.Controllers
{
    public class CourseController : Controller
    {
        private ICourseService<Course, CourseInformationDTO> _course;
        public CourseController(ICourseService<Course, CourseInformationDTO> course)
        {
            _course = course;
        }
        public IActionResult Index()
        {
            var model = _course.GetAllWithRelationship();
            return View(model);
        }
    }
}
