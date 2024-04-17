using Microsoft.AspNetCore.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var testModel = new TestModel
            {
                Name = "Test",
                Description = "This is a test model."
            };

            return View(testModel);
        }
    }
}
