using Microsoft.AspNetCore.Mvc;
using UniversityStudyPlatform.DataAccess.Data;
using UniversityStudyPlatform.DataAccess.Repository;
using UniversityStudyPlatform.Models;

namespace UniversityStudyPlatform.Controllers
{
    public class Courses : Controller
    {
        private IRepository<Course> courseRepository;

        public Courses(IRepository<Course> _courseRepository)
        {
            courseRepository = _courseRepository;
        }

        public IActionResult Index()
        {
            IEnumerable<Course> coursesList = courseRepository.GetAll();
            return View(coursesList);
        }
    }
}
