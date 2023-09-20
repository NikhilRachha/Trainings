using static WebApplication5.Models.EntityModelClasses;

namespace WebApplication5.Repositories
{
    public interface IStudentRepository
    {
        List<Student> GetAllStudents();
        Student GetStudentById(int id);
        void AddStudent(Student studentObj);

        Student GetStudentByName(string name);
    }
}
