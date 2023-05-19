using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityStudyPlatform.DataAccess.Data;
using UniversityStudyPlatform.Models;

namespace UniversityStudyPlatform.DataAccess.Repository
{
    public class UnitOfWork: IUnitOfWork
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

        public ApplicationDbContext db { get; }

        public UnitOfWork(ApplicationDbContext _db)
        {
            db = _db;
            accountBookRepository = new Repository<AccountBook>(_db);
            assignmentRepository = new Repository<Assignment>(_db);
            courseRepository = new Repository<Course>(_db);
            courseGroupRepository = new Repository<CourseGroup>(_db);
            groupRepository = new Repository<Group>(_db);
            loginDataRepository = new Repository<LoginData>(_db);
            messageRepository = new Repository<Message>(_db);
            sheduleRepository = new Repository<Shedule>(_db);
            studentRepository = new Repository<Student>(_db);
            studentIndividualTaskRepository = new Repository<StudentIndividualTask>(_db);
            studentPerformanceRepository = new Repository<StudentPerfomance>(_db);
            personRepository = new Repository<Person>(_db);
            subjectRepository = new Repository<Subject>(_db);
            teacherRepository = new Repository<Teacher>(_db);
            vmLoginRepository = new Repository<VMLogin>(_db);
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
