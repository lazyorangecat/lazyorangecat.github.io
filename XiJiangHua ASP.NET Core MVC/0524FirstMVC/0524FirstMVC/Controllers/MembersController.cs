using Microsoft.AspNetCore.Mvc;

namespace _0524FirstMVC.Controllers
{
    public class MembersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List()
        {
            return View();
        }
    }
}
