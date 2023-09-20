using static WebApplication5.Models.EntityModelClasses;

namespace WebApplication5.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private SchoolDbContext _dbConext;

        public StudentRepository(SchoolDbContext dbContext)
        {
            _dbConext = dbContext;
        }
        public List<Student> GetAllStudents()
        {
            return _dbConext.Students.ToList();
        }

        public Student GetStudentById(int id)
        {
            return _dbConext.Students.Find(id);
        }

        public Student GetStudentByName(string Name)
        {
            return _dbConext.Students.Find(Name);
        }

        public void AddStudent(Student studentObj)
        {
            _dbConext.Students.Add(studentObj);
            _dbConext.SaveChanges();
        }
    }
}
