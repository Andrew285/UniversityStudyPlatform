using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityStudyPlatform.Models
{
    public class Group
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<AccountBook> AccountBooks { get; set; }
        public ICollection<CourseGroup> CourseGroups { get; set; }
        public ICollection<Shedule> Shedule { get; set; }
    }
}
