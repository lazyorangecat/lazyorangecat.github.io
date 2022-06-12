using _0524FirstMVC.Data;
using _0524FirstMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace _0524FirstMVC.Controllers
{
    public class ProductController : Controller
    {
        private MemberContext _context;
        public ProductController()
        {
            _context = new MemberContext();
        }

        public IActionResult CarListDB()
        {
            var products = _context.Products.ToList();
            return View("CarList",products);
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Car()
        {
            Product product = new Product
            {
                Id = 1,
                ProductName = "Ferrari 296 GTB",
                UnitPrice = 1616161,
                ImageUrl = "https://autos.yahoo.com.tw/p/r/w880/car-models/November2021/NB9n7re2C6OIisCSnALF.jpg"

            };
            return View(product);
        }

        public IActionResult CarList()
        {
            List<Product> products = new List<Product>
            {
                new Product{Id = 1,ProductName="Ferrari 296 GTB",UnitPrice =1616161,ImageUrl= "https://autos.yahoo.com.tw/p/r/w880/car-models/November2021/NB9n7re2C6OIisCSnALF.jpg"},
                new Product{Id = 2,ProductName="大穩發",UnitPrice =638000,ImageUrl= "https://image.u-car.com.tw/file_26223.jpg"}
            };
            
            //return View(product);

            ViewData.Model = products;
            return View();
        }
    }
}
