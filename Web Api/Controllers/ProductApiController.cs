using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static WebApplication6.Models.EntityModelClasses;

namespace WebApplication6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductApiController : ControllerBase
    {

        private ProductDbContext dbcontext;

        public ProductApiController(ProductDbContext dbContext)
        {
            dbcontext = dbContext;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(dbcontext.Products.ToList());
        }
        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            Product product = dbcontext.Products.Find(id);
            if (product == null)
            {
                return NotFound(new { result = "not Found" });



            }
            else
            {
                return Ok(product);
            }
        }
   
     
        [HttpPost]
        public IActionResult Create([FromBody] Product product)
        {
            dbcontext.Products.Add(product);
            dbcontext.SaveChanges();
            return Ok(new { result = "Created new row" });
        }
        [HttpPut]
        public IActionResult Edit([FromBody] Product obj)
        {
            dbcontext.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbcontext.SaveChanges();
            return Ok(new { result = "Updated Succesfully" });
        }
        [HttpDelete]
        public IActionResult Delete([FromBody] int i)
        {
            Product obj = dbcontext.Products.Find(i);
            dbcontext.Products.Remove(obj);
            dbcontext.SaveChanges();
            return Ok(new { result = "Deleted" });
        }
    }
}
