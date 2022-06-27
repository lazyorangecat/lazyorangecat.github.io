using Microsoft.AspNetCore.Mvc;

namespace _0624_ReBuild_CoreMvc5_Razor.Controllers
{
    public class RazorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult RazorStatement()
        {
            return View();
        }
    }
}
