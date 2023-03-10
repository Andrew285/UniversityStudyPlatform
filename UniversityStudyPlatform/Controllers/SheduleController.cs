using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;
using UniversityStudyPlatform.DataAccess.Repository;
using UniversityStudyPlatform.Models;

namespace UniversityStudyPlatform.Controllers
{
    public class SheduleController : Controller
    {
        private IRepository<Shedule> sheduleRepository;

        public SheduleController(IRepository<Shedule> _sheduleRepository)
        {
            sheduleRepository = _sheduleRepository;
        }

        // GET: SheduleController
        public ActionResult Index()
        {
            IEnumerable<Shedule> coursesList = sheduleRepository.GetAll();
            return View(coursesList);
        }

        // GET: SheduleController/Details/5
        public ActionResult Details(int id)
        {
            return View();
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
