using Microsoft.AspNetCore.Mvc;
using UniversityStudyPlatform.DataAccess.UnitOfWork;
using UniversityStudyPlatform.Models;

namespace UniversityStudyPlatform.Controllers
{
    public class CurriculumController : Controller
    {
        private IUnitOfWork unitOfWork;

        public CurriculumController(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }

        public IActionResult Index()
        {
            List<Course> coursesByStudent = new List<Course>();
            List<Subject> subjects = new List<Subject>();
            List<Teacher> teachers = new List<Teacher>();
            List<CreditForm> creditForms = new List<CreditForm>();
            List<Term> terms = new List<Term>();
            int id = ViewBag.StudentId;
            if (TempData.ContainsKey("StudentId"))
            {
                Student student = (Student)TempData["StudentId"];
                coursesByStudent = unitOfWork.courseRepository.GetCoursesByStudent(unitOfWork.studentRepository.GetFirstOrDefault(u => u.Id == student.Id));

                foreach(Course course in coursesByStudent)
                {
                    subjects.Add(unitOfWork.subjectRepository.GetFirstOrDefault(u => u.SubjectId == course.SubjectId));
                    teachers.Add(unitOfWork.teacherRepository.GetFirstOrDefault(u => u.Id == course.TeacherId));
                    creditForms.Add(unitOfWork.creditFormRepository.GetFirstOrDefault(u => u.Id == course.CreditFormId));
                    terms.Add(unitOfWork.termRepository.GetFirstOrDefault(u => u.Id == course.TermId));
                }

                ViewBag.Courses = coursesByStudent;
                ViewBag.Subjects = subjects;
                ViewBag.Teachers = teachers;
                ViewBag.CreditForms = creditForms;
                ViewBag.Terms = terms;
            }

            return View();
        }
    }
}
