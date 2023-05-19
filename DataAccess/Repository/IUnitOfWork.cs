using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityStudyPlatform.Models;

namespace UniversityStudyPlatform.DataAccess.Repository
{
    public interface IUnitOfWork
    {
        public IRepository<AccountBook> accountBookRepository { get; set; }
        public IRepository<Assignment> assignmentRepository { get; set; }
        public IRepository<Course> courseRepository { get; set; }
        public IRepository<CourseGroup> courseGroupRepository { get; set; }
        public IRepository<Group> groupRepository { get; set; }
        public IRepository<LoginData> loginDataRepository { get; set; }
        public IRepository<Message> messageRepository { get; set; }
        public IRepository<Shedule> sheduleRepository { get; set; }
        public IRepository<Student> studentRepository { get; set; }
        public IRepository<StudentIndividualTask> studentIndividualTaskRepository { get; set; }
        public IRepository<StudentPerfomance> studentPerformanceRepository { get; set; }
        public IRepository<Person> personRepository { get; set; }
        public IRepository<Subject> subjectRepository { get; set; }
        public IRepository<Teacher> teacherRepository { get; set; }
        public IRepository<VMLogin> vmLoginRepository { get; set; }

        void Save();
    }
}
