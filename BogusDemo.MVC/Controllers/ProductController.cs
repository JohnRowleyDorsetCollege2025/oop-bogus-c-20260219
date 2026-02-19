using BogusDemo.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace BogusDemo.MVC.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = FakeDataService.GenerateFakeProducts(100);


            return View(products);
        }
    }
}
