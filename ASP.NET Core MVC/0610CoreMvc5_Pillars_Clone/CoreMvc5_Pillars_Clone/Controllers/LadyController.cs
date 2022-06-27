using Microsoft.AspNetCore.Mvc;

namespace CoreMvc5_Pillars_Clone.Controllers
{
    public class LadyController : Controller
    {
        public IActionResult portal()
        {
            return View();
        }
    }
}
