using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static WebApplication5.Models.EntityModelClasses;
using WebApplication5.Services;

namespace WebApplication5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentApiController : ControllerBase
    {
        private IStudentService _studentService;

        public StudentApiController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        // Read All
        [HttpGet]
        public IActionResult GetStudents()
        {
            return Ok(_studentService.GetAllStudents());
        }

        [HttpPost]
        public IActionResult Create([FromBody] Student obj)
        {
            _studentService.AddStudent(obj);
            return Ok(new { result = "Emp Details added to db" });
        }



        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
            Student obj = _studentService.GetStudentById(id);

            if (obj == null)
            {
                return NotFound(new { result = "Requested employee details are not available." });
            }
            else
            {
                return Ok(obj);
            }
        }

        [HttpGet("{Name}")]
        public IActionResult GetStudentyName(string Name)
        {
            Student obj = _studentService.GetStudentByName(Name);

            if (obj == null)
            {
                return NotFound(new { result = "Requested Student details are not available." });
            }
            else
            {
                return Ok(obj);
            }
        }

    }
}
