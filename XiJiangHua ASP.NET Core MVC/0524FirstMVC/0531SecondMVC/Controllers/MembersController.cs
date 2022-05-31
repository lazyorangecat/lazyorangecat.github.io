using _0531SecondMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace _0531SecondMVC.Controllers
{
    public class MembersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            //建立模型
            List<Member> members = new List<Member>
            {
                    new Member { Id=1, Name="XXX", Brief="XXX", Photo="github..." },
        new Member { Id=2, Name="XXX", Brief="XXX", Photo="github..." },
        new Member { Id=3, Name="XXX", Brief="XXX", Photo="github..." },
        new Member { Id=4, Name="XXX", Brief="XXX", Photo="github..." },
                 new Member { Id=5, Name="XXX", Brief="XXX", Photo="github..." },
        new Member { Id=6, Name="XXX", Brief="XXX", Photo="github..." },
        new Member { Id=7, Name="XXX", Brief="XXX", Photo="github..." }
    };


            ViewData["Members"] = members;  //1.透過ViewData傳遞資料給View
            ViewBag.Members = members;  //2.透過ViewBag傳遞資料給View

            return View(members);  //3.透過Model將model物件資料傳給View檢視
        }

    }
}
