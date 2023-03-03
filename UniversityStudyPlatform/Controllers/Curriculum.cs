using Microsoft.AspNetCore.Mvc;

namespace UniversityStudyPlatform.Controllers
{
    public class Curriculum : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
