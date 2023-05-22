using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityStudyPlatform.DataAccess.Data;
using UniversityStudyPlatform.Models;

namespace UniversityStudyPlatform.DataAccess.UnitOfWork.Repository
{
    public class SheduleRepository : Repository<Shedule>
    {
        private ApplicationDbContext db;

        public SheduleRepository(ApplicationDbContext _db) : base(_db)
        {
            db = _db;
        }
    }
}
