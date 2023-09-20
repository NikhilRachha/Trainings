using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Product()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Product(string productName,int UnitPrice,int Quantity)
        {
            int finalAmt = 0;
            finalAmt = UnitPrice*Quantity;
            ViewBag.Message = finalAmt;
            return View();
        }
        public IActionResult Items()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Items(string ItemName, int ItemPrice, int ItemQuantity)
        {
            int finalAmt1 = 0;
            finalAmt1 = ItemPrice * ItemQuantity;
            ViewBag.Message = finalAmt1;
            return View();
        }

        [HttpPost]
        public IActionResult Contact(string uid, string pwd)
        {
            if (uid == "nikhil" && pwd == "1858")
            { 
                ViewBag.Message = "Welcome Nikhil";
            }
            else
            {
                ViewBag.Message = "UserName and Password Incorrect";
            }
            return View();
        }
        public IActionResult Login()
        {
            List<Product> products = new List<Product>()
         {
    new Product(){ProductId=1,ProductName="LG1",ProductPrice=600},
    new Product(){ProductId=2,ProductName="LG2",ProductPrice=700},
    new Product(){ProductId=3,ProductName="LG3",ProductPrice=800}
    };
            return View(products);
        }
    }
}
