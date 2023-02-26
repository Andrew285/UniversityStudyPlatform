using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityStudyPlatform.Models
{
    public class AccountBook
    {
        [ForeignKey("Student")]
        public int AccountBookId { get; set; }
        public Student Student { get; set; }

        public ICollection<StudentPerfomance> StudentPerfomances { get; set; }
    }
}
