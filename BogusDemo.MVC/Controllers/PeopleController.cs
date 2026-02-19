using BogusDemo.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace BogusDemo.MVC.Controllers
{
    public class PeopleController : Controller
    {
        public IActionResult Index()
        {
            var people = FakeDataService.GenerateFakePeople(100);


            return View(people);
        }
    }
}
