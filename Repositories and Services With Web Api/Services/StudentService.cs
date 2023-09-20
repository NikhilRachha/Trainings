using static WebApplication5.Models.EntityModelClasses;
using WebApplication5.Repositories;
using Microsoft.EntityFrameworkCore;

namespace WebApplication5.Services
{
    public class StudentService : IStudentService
    {
        private IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public List<Student> GetAllStudents()
        {
            return _studentRepository.GetAllStudents();
        }

        public Student GetStudentById(int id)
        {
            return _studentRepository.GetStudentById(id);
        }

        public Student GetStudentByName(string Name)
        {
            return _studentRepository.GetStudentByName(Name);
        }

        public void AddStudent(Student studentObj)
        {
            _studentRepository.AddStudent(studentObj);
        }
    }
}
