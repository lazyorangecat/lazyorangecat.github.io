using Microsoft.AspNetCore.Mvc;

namespace CoreMvc5_Pillars_Clone.Controllers
{
    public class SirController : Controller
    {
        public IActionResult Entrypoint()
        {
            return View();
        }
    }
}
