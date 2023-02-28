using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityStudyPlatform.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int SubjectId { get; set; }
        public Subject Subject { get; set; }

        ICollection<CourseGroup> CourseGroups { get; set; }
    }
}
