using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityStudyPlatform.DataAccess.Data;
using UniversityStudyPlatform.DataAccess.Repository.IRepository;
using UniversityStudyPlatform.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace UniversityStudyPlatform.DataAccess.UnitOfWork.Repository
{
    public class SheduleRepository : Repository<Shedule>, ISheduleRepository
    {
        public SheduleRepository(ApplicationDbContext _db) : base(_db) { }

        public List<List<Shedule>> GetAllShedule(Student student)
        {

            var group1 = from b in db.AccountBooks
                         where b.StudentId == student.Id
                         select b;

            //var sheduleListValue = from c in db.Shedule
            //                  where c.GroupId == group1.FirstOrDefault().GroupId
            //                  orderby c.Day
            //                  select c;

            List<List<Shedule>> sheduleList = new List<List<Shedule>>();
            
            for (int k = 0; k < Enum.GetNames(typeof(Day)).Length; k++)
            {
                    var sheduleListOfDay = from c in db.Shedule
                                           where c.GroupId == group1.FirstOrDefault().GroupId && c.Day ==(Day)k
                                           orderby c.NumberPara
                                           select c;
                List<Shedule> dayList = new List<Shedule>();
                for (int j = 0; j < sheduleListOfDay.Count(); j++)
                {
                    dayList.Add(sheduleListOfDay.ToList().ElementAt(j));
                }
                sheduleList.Add(dayList);
            }
            return sheduleList;
        }

    }
}
