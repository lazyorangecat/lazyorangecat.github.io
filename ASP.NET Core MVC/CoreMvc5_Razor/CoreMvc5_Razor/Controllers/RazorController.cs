using Microsoft.AspNetCore.Mvc;

namespace CoreMvc5_Razor.Controllers
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
