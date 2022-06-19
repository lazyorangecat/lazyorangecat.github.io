using _0524FirstMVC.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace _0524FirstMVC.Controllers
{
    public class SiteController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SearchMemberByName(string name)        //先確定能被呼叫       name資料能被抓進來
        {
            if (string.IsNullOrEmpty(name))
                return Content("請輸入內容");

            MemberContext context = new MemberContext();
            var members = context.Members.Where(x => x.Name.Contains(name)).ToList();

            //判斷集合是否有資料
            if (members.Count == 0)
                return Content($"找不到任何的{name}資料紀錄");

            //指派使用ListTable.cshtml
            return View("~/Views/Members/ListTable.cshtml", members);
        }
    }
}
