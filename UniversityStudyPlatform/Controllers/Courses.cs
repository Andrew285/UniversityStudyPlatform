using Microsoft.AspNetCore.Mvc;

namespace UniversityStudyPlatform.Controllers
{
    public class Courses : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
