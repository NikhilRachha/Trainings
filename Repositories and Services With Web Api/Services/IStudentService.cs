using static WebApplication5.Models.EntityModelClasses;

namespace WebApplication5.Services
{
    public interface IStudentService
    {
        List<Student> GetAllStudents();
        Student GetStudentById(int id);
        void AddStudent(Student studentObj);

        Student GetStudentByName(string name);
    }
}
