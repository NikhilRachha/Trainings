using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class StudentController : Controller
    {
        SchoolDbContext dbcontext;

        public StudentController(SchoolDbContext context)
        {
            dbcontext = context;
        }
        public IActionResult Index()
        {
            return View(dbcontext.Students.ToList());
        }
        [HttpGet]

        public IActionResult Create() {
            return View();
        }

        [HttpPost]

        public IActionResult Create(Student obj) {
            dbcontext.Students.Add(obj);
            dbcontext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            Student obj = dbcontext.Students.Find(id);
            return View(obj);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Student obj = dbcontext.Students.Find(id);
            return View(obj);
        }

        [HttpPost]
        public IActionResult Edit(Student obj)
        {
            dbcontext.Entry(obj).State=Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbcontext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Student obj = dbcontext.Students.Find(id);
            return View(obj);
        }

        [HttpPost]
        public IActionResult Delete(string id)
        {
            Student obj = dbcontext.Students.Find(int.Parse(id));
            dbcontext.Students.Remove(obj);
            dbcontext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
