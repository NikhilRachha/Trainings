using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebApplicationCaseStudyProject.Models;

namespace WebApplicationCaseStudyProject.Controllers
{
    public class HomeController : Controller
    {
    
        OfficeDbContext dbcontext;

        public HomeController(OfficeDbContext _context)
        {
            dbcontext = _context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string pass)
        {
           User name= dbcontext.Users.Where(u => (u.UserName == username) && (u.UserPassword == pass)).SingleOrDefault();
            if (name!=null)
            {
                return RedirectToAction("Index","Employee");
            }
            else
            {
                ViewBag.Message = "Incorrect Admin Credentials";
                return View();
            }

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}