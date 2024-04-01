using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Lr9.Models;

namespace Lr9.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<ProductModel>
        {
            new ProductModel { ID = 1, Name = "Laptop", Price = 800},
            new ProductModel { ID = 2, Name = "Monitor", Price = 250},
            new ProductModel { ID = 3, Name = "Keyboard", Price = 50},
            new ProductModel { ID = 4, Name = "Mouse", Price = 30},
        };

            return View(products);
        }
    }
}
