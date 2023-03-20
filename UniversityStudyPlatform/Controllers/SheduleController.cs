using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;
using System.Security.Claims;
using UniversityStudyPlatform.DataAccess.Repository;
using UniversityStudyPlatform.Models;

namespace UniversityStudyPlatform.Controllers
{
    public class SheduleController : Controller
    {
        private IRepository<Shedule> sheduleRepository;
        private IRepository<Student> studentRepository;
        private IRepository<AccountBook> accountBookRepository;

        public SheduleController(IRepository<Shedule> _sheduleRepository, IRepository<Student> studentRepository, IRepository<AccountBook> accountBookRepository)
        {
            sheduleRepository = _sheduleRepository;
            this.studentRepository = studentRepository;
            this.accountBookRepository = accountBookRepository;
        }

        //GET: SheduleController
        //public ActionResult Index()
        //{
        //    IEnumerable<Shedule> coursesList = sheduleRepository.GetAll();
        //    return View(coursesList);
        //}

        // GET: SheduleController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public IActionResult Index()
        {
            //check if user is logged in
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

            Student studentCard = studentRepository.GetFirstOrDefault(
                u => u.Email == claim.Value);
            AccountBook AccountBookCard = accountBookRepository.GetFirstOrDefault(
                u => u.StudentId == studentCard.Id);
            int groupId = AccountBookCard.GroupId;
            IEnumerable<Shedule> sheduleList = sheduleRepository.GetAll(
                u => u.GroupId == groupId);

            return View(sheduleList);
        }

        // GET: SheduleController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SheduleController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SheduleController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SheduleController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SheduleController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SheduleController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
