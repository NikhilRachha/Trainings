using Microsoft.EntityFrameworkCore;

namespace WebApplicationCaseStudyProject.Models
{
        public class User
        {
            public int UserId { get; set; }
            public string UserName { get; set; }
            public string UserPassword { get; set; }
            public string UserEmail { get; set; }
        }

        public class Employee
        {
            public int EmployeeId { get; set; }
            public string EmployeeName { get; set; }
            public string EmployeeJob { get; set; }
            public int EmployeeSalary { get; set; }
            public string EmployeeDepartment { get; set; }
        }

        public class OfficeDbContext : DbContext
        {
            public DbSet<User> Users { get; set; }

            public DbSet<Employee> Employees { get; set; }

            public OfficeDbContext(DbContextOptions<OfficeDbContext> options)
             : base(options)
            {

            }
        }

        
}
