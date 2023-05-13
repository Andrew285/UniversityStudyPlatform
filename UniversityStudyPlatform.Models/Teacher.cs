using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityStudyPlatform.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }

        [Required]
        public string Role { get; set; }

        public LoginData LoginData { get; set; }

        ICollection<Shedule> Shedule { get; set; }
        ICollection<Course> Course { get; set; }
    }
}
