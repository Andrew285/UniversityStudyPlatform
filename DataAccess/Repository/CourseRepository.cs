using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityStudyPlatform.DataAccess.Data;
using UniversityStudyPlatform.Models;

namespace UniversityStudyPlatform.DataAccess.Repository
{
    public class CourseRepository: Repository<Course>
    {
        private ApplicationDbContext db;

        public CourseRepository(ApplicationDbContext _db): base(_db)
        {
            db = _db;
        }
    }
}
