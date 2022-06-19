using Microsoft.AspNetCore.Mvc;

namespace _0524FirstMVC.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
