using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using UniversityStudyPlatform.DataAccess.Repository;
using UniversityStudyPlatform.Models;

namespace UniversityStudyPlatform.Controllers
{
    public class CurriculumController : Controller
    {
        private IRepository<StudentPerfomance> studentPerfomanceRepository;
        private IRepository<Student> studentRepository;
        private IRepository<AccountBook> accountBookRepository;

        public CurriculumController(IRepository<StudentPerfomance> _studentPerfomanceRepository, IRepository<Student> studentRepository, IRepository<AccountBook> accountBookRepository)
        {
            studentPerfomanceRepository = _studentPerfomanceRepository;
            this.studentRepository = studentRepository;
            this.accountBookRepository = accountBookRepository;
        }

        //public IActionResult Index()
        //{
        //    //check if user is logged in
        //    //var claimsIdentity = (ClaimsIdentity)User.Identity;
        //    //var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

        //    //Student studentCard = studentRepository.GetFirstOrDefault(
        //    //    u => u.Email == claim.Value);
        //    //AccountBook AccountBookCard = accountBookRepository.GetFirstOrDefault(
        //    //    u => u.StudentId == studentCard.Id);
        //    //IEnumerable<StudentPerfomance> studentPerfomanceList = studentPerfomanceRepository.GetAll(
        //    //    u => u.AccountBookId == AccountBookCard.Id);
        //    //studentPerfomanceList.OrderBy(c => c.SemesterNumber);
        //    return View(studentPerfomanceList);
        //}
    }
}
