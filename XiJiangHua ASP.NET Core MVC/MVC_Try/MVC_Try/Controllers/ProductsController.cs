using Microsoft.AspNetCore.Mvc;

namespace MVC_Try.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
