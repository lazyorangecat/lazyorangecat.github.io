using Microsoft.AspNetCore.Mvc;
using System;

namespace CoreMvc5_Pillars_Clone.Controllers
{
    public class PassDataController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult PassTempData()
        {
            TempData["ErrorMessage"] = "無足夠權限，請聯絡管理員";
            TempData["UserName"] = "David";
            TempData["Time"] = DateTime.Now.ToLongTimeString();
            return RedirectToAction("ErrorMessage", "ErrorHandler");
        }
    }
}
