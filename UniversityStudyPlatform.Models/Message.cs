using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityStudyPlatform.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string Body { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
