using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplicationCaseStudyProject.Models;

namespace WebApplicationCaseStudyProject.Controllers
{
    public class EmployeeController : Controller
    {
        OfficeDbContext dbcontext;

        public EmployeeController(OfficeDbContext context)
        {
            dbcontext = context;
        }
        public IActionResult Index()
        {
            return View(dbcontext.Employees.ToList());
        }

        [HttpGet]

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Create(Employee obj)
        {
            dbcontext.Employees.Add(obj);
            dbcontext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            Employee obj = dbcontext.Employees.Find(id);
            return View(obj);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Employee obj = dbcontext.Employees.Find(id);
            return View(obj);
        }

        [HttpPost]
        public IActionResult Edit(Employee obj)
        {
            dbcontext.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbcontext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Employee obj = dbcontext.Employees.Find(id);
            return View(obj);
        }

        [HttpPost]
        public IActionResult Delete(string id)
        {
            Employee obj = dbcontext.Employees.Find(int.Parse(id));
            dbcontext.Employees.Remove(obj);
            dbcontext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DepartmentDetails()
        {
            List<string> uniqueDepartmentNames = dbcontext.Employees.Select(i => i.EmployeeDepartment).Distinct().ToList();



            ViewBag.UniqueDepartmentNames = uniqueDepartmentNames;
            return View();
        }

        [HttpGet]

        public IActionResult Dept(string id)
        {
            List<Employee> obj = dbcontext.Employees.Where(i => i.EmployeeDepartment == id).ToList();
            if(obj == null)
            {
                return NotFound(new { result = " Records not Found" });
            }
            else
            {
                return View(obj);
            }
        }

    }
}
