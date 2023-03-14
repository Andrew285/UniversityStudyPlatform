using Microsoft.AspNetCore.Mvc;

namespace UniversityStudyPlatform.Controllers
{
    public class CurriculumController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
