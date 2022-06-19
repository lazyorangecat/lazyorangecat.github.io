using Microsoft.AspNetCore.Mvc;

namespace CoreMvc5_Pillars_Clone.Controllers
{
    public class ErrorHandlerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [TempData]
        public string Message { get; set; }
        public IActionResult ErrorMessage()
        {
            if(!TempData.ContainsKey("ErrorMessage"))
            {
                return new EmptyResult();
            }

            TempData.Keep();
            //TempData.Keep("ErrorMessage")
            return View();
        }
    }
}
