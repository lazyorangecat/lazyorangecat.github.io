using Microsoft.AspNetCore.Mvc;
using _0524FirstMVC.Models;
using System.Collections.Generic;
using Newtonsoft.Json;
using _0524FirstMVC.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

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
            //建立模型
            List<Member> members = new List<Member>
            {
                new Member { Id = 1, Name = "林詠琦", Brief = "我的興趣大吃大喝，喜歡購物，就是沒錢", Photo = "https://raw.githubusercontent.com/YongChyi/YongChyi.github.io/main/45296.jpg",Department = "國際企業學系",Gender = false,City = "Malaysia",FuturePlan = "Work",Salary = "40000-50000",Team = "第一組" },
                new Member { Id = 2, Name = "林詩琦", Brief = "雙胞胎姐姐" , Photo = "https://raw.githubusercontent.com/ShiChyiLim/ShiChyiLim.github.io/main/1784C24F-3C76-475D-A246-B8B1F58CBD7E.jpg",Department = "國際企業學系",Gender = false,City = "Malaysia",FuturePlan = "Study",Salary = "40000-60000",Team = "第一組"},
                new Member { Id = 3, Name = "Neil", Brief = "單身", Photo = "https://raw.githubusercontent.com/Neil-Yang3759/Neil-Yang3759.github.io/main/JS/HW1/selfie.jpg",Department = "資訊工程學系",Gender = true,City = "新竹市",FuturePlan = "Work",Salary = "100000-150000",Team = "第一組"},
                new Member { Id = 4, Name = "王紀翔", Brief = "123", Photo = "https://raw.githubusercontent.com/shaun881017/shaun881017.github.io/main/JS_HW1/D1F75C32-5FF6-4442-AA67-47A11D25F468.jpg",Department = "資訊工程學系",Gender = true,City = "新北市",FuturePlan = "Study",Salary = "50000-60000",Team = "第一組"},
                new Member { Id = 5, Name = "余仲恩", Brief = "窩不知道", Photo = "https://raw.githubusercontent.com/ycm123/FileStorage/main/20712.jpg",Department = "資訊工程學系",Gender = true,City = "苗栗縣",FuturePlan = "Work",Salary = "36000-40000",Team = "第一組"},
                new Member { Id = 6, Name = "林秉謙", Brief = "喜歡玩遊戲", Photo = "https://raw.githubusercontent.com/Silmonght/Silmonght.github.io/main/steven.jpg",Department = "資訊工程學系",Gender = true,City = "雲林縣",FuturePlan = "Study",Salary = "38000-45000",Team = "第一組"},
                new Member { Id = 7, Name = "魏子涵", Brief = "I’m very communicative, detail-oriented, and versatile. I like to think of myself as a team player. While I don’t mind taking on solo projects, I prefer to work with others.I like to think that I’m persistent and persuasive. Working in sales, these traits have served me well. Outside of work, I enjoy taking part in lively debates where I can share my views with others.", Photo = "https://raw.githubusercontent.com/Neil-Yang3759/FileStorage/main/IMG_0299.jpg",Department = "企業管理學系",Gender = true,City = "新竹市",FuturePlan = "Work",Salary = "100000-150000" ,Team = "第一組"},

                new Member{Id =8 , Name = "李家萱", Brief = "最愛南柱赫!!!!!", Photo = "https://raw.githubusercontent.com/JiaXuan1083/FileStorage/main/IMG_7403.JPG", Department = "觀光與會展活動學系", Gender = false, City = "基隆市", FuturePlan = "work", Salary = "40000-45000", Team = "第二組"},
                new Member{Id =9 , Name = "廖培余", Brief = "打羽球", Photo = "https://raw.githubusercontent.com/yu1129/hard/main/%E4%BD%99.jpg", Department = "生物資訊學系 ", Gender = false, City = "雲林縣", FuturePlan = "work", Salary = "40000-48000", Team = "第二組"},
                new Member{Id = 10, Name = "吳霈玟", Brief = "聽音樂", Photo = "https://raw.githubusercontent.com/wen-0510/FileStorages/main/1.jpg",Department = "生物資訊學系",Gender = false,City = "高雄市",FuturePlan = "study",Salary = "42000-48000", Team = "第二組"},
                new Member{Id =11 , Name = "朱彥蓉", Brief = "愛貓", Photo = "https://raw.githubusercontent.com/t333685/t333685.github.io/590201655655be034c9866169ddbab949d138e33/S__7020548.jpg", Department = "生物資訊學系 ", Gender = false, City = "苗栗縣", FuturePlan = "work", Salary = "35000-40000", Team = "第二組"},
                new Member{Id = 12, Name = "盧致文", Brief = "瑜珈", Photo = "https://raw.githubusercontent.com/chihwen1215/FileStorage/main/S__35127335.jpg",Department = "生物資訊學系", Gender = false, City = "台南市", FuturePlan = "work", Salary = "40000-45000", Team = "第二組"},
                new Member{Id = 13, Name = "楊子慧", Brief = "打羽球", Photo = "https://raw.githubusercontent.com/LittleY11/FileStorage/main/photo.jpg",Department = "工業管理學系", Gender = false, City = "台中市", FuturePlan = "study", Salary = "40000-45000", Team = "第二組"},
                new Member{Id = 14, Name = "戴閣廷", Brief = "看比賽", Photo = "https://raw.githubusercontent.com/hi8787h/hi8787h.github.io/main/photo/Myphoto.png",Department="資訊工程學系",Gender=true,City="桃園市",FuturePlan="work",Salary="36000-42000", Team = "第二組"},
                new Member{Id = 15, Name = "江昱寬", Brief = "看女團", Photo = "https://raw.githubusercontent.com/Kuan1215/FileStorage/main/D6480B08-E095-456D-BB43-C0372D0FB0AC.jpg" ,Department = "生物資訊學系",Gender =true,City = "桃園市",FuturePlan = "work",Salary = "70000-150000", Team = "第二組"},

                new Member {Id = 16,Team = "第三組",Name = "陳妤瑄",Brief ="超愛出去玩",Photo ="https://raw.githubusercontent.com/Jamie1721/FileStorage/main/S__6267102.jpg",Department ="企業管理學系",Gender =false,City ="桃園市",FuturePlan ="Work",Salary ="35000 ~ 40000"},
                new Member {Id = 17,Team = "第三組",Name = "陳柏宇",Brief ="超愛羽球",Photo ="https://raw.githubusercontent.com/Ankepoyou/FileStorage/main/IMG_20210518_154803_800.jpg", Department ="資訊管理學系",Gender =true,City ="台北市",FuturePlan ="Work",Salary ="35000 ~ 40000"},
                new Member {Id = 18,Team = "第三組",Name = "徐秉詰",Brief ="上網",Photo ="https://raw.githubusercontent.com/3TeT3/FileStorage_/main/16140801732026.jpg",Department ="資訊工程學系",Gender = true,City ="南投縣", FuturePlan ="Work",Salary ="35000-42000"},
                new Member {Id = 19,Team = "第三組",Name = "陳亮羽",Brief ="看漫畫",Photo ="https://raw.githubusercontent.com/liang10713/FileStorage/main/64102.jpg",Department ="工業工程管理學系",Gender=false,City="新竹市",FuturePlan="Work",Salary="35000 ~ 40000"},
                new Member {Id = 20,Team = "第三組",Name = "劉禮婷",Brief ="玩摩爾",Photo ="https://raw.githubusercontent.com/Lyting030/Lyting030.github.io/main/0524.jpg",Department ="生物資訊系",Gender=false,City="新北市",FuturePlan="Study",Salary="40000 ~ 50000"},
                new Member {Id = 21,Team = "第三組",Name = "楊景琁",Brief ="看漫畫",Photo ="https://raw.githubusercontent.com/Kei209/FileStorage/main/2022-05-24-15-52-31-817.jpg",Department ="工業工程管理學系(原科技管理學系)",Gender = false,City ="台東縣",FuturePlan ="Work",Salary ="36000-42000"},
                new Member {Id = 22,Team = "第三組",Name = "范華軒",Brief ="看漫畫",Photo ="https://fan-hua-hsuan.github.io/photo/hana.jpg,",Department = "應用日語學系",Gender =false,City ="新竹縣",FuturePlan ="Study",Salary ="35000 ~ 40000"},
                new Member {Id = 23,Team = "第三組",Name = "林盈均",Brief ="追劇",Photo ="https://raw.githubusercontent.com/linyign/FileStorage/main/pic.jpg",Department ="工業工程管理學系",Gender=false,City="新竹縣",FuturePlan="Work",Salary="36000-42000"},
                new Member {Id = 24,Team = "第三組",Name = "彭宗文",Brief ="看書",Photo ="https://raw.githubusercontent.com/DavidPeng1/FileStorage/main/IMG_0039.JPG",Department ="資訊工程學系",Gender = true,City ="新竹市",FuturePlan ="NA",Salary =" 200000 ~ 500000"},


                new Member{Id=25,Name="楊明翰",Brief="抽菸,飆車,",Department="國際企業系",Gender=true,City="宜蘭縣",FuturePlan="work",Salary="38000~42000",Team="第四組",Photo="https://raw.githubusercontent.com/ert3455668/ert3455668.github.io/main/JavaScript/77F5723D-D640-4DA9-A57C-2C1542D58145.jpg"},
                new Member{Id=26,Name="羅世晏",Brief="充滿文學氣質的文藝青年",Department="航海系",Gender=true,City="新竹縣",FuturePlan="work+study",Salary="36000~45000",Team="第四組",Photo="https://raw.githubusercontent.com/LoShinYen/FileStorages/main/S__5750791.jpg" },
                new Member{Id=27,Name="張添宇",Brief="可愛又迷人的反派角色",Department = "資管系",Gender = true, City = "新竹市",FuturePlan = "work+study",Salary = "40000~40002",Team="第四組",Photo="https://raw.githubusercontent.com/RainRoc1222/RainRoc1222.github.io/main/178099682_6502551609770280_5658538484540389917_n.jpg"},
                new Member{Id=28,Name="王泓凱",Brief="平時喜好打APEX、LOL最近每天去打撞球",Department = "資管系",Gender = true, City = "",FuturePlan = "",Salary = "",Team="第四組",Photo="https://raw.githubusercontent.com/PurerKai/MVCAPI/main/myself.png"},
                new Member{Id=29,Name="吳奕君",Brief="聽音樂、看看書、過生活", Department = "資工系", Gender = false, City = "新竹市", FuturePlan ="stuty", Salary = "38000~40000",Team="第四組",Photo="https://raw.githubusercontent.com/Chun-2000/Chun-2000.github.io/main/MyPhoto.jpg"},
                new Member{Id=30,Name="王俐璇",Brief="甜點愛好者", Department = "資工系", Gender = false, City = "台南市", FuturePlan = "stuty", Salary = "36000-42000",Team="第四組",Photo="https://raw.githubusercontent.com/Lemon-2001/FileStoreage/main/MVC/Hsuan.jpeg"},
                new Member{Id=31,Name="郭柏言",Brief="可以坐著就不要站著，可以躺著就不要坐著",Department = "資管系",Gender = true, City = "台南市",FuturePlan = "work",Salary = "40000~45000",Team="第四組",Photo="https://lazyorangecat.github.io/XiJiangHua%20ASP.NET%20Core%20MVC/0524FirstMVC/12.jpeg"},
            };
            
            string jsonMembers = JsonConvert.SerializeObject(members);

            ViewData["jsonMembers"] = jsonMembers;
            ViewData["Members"] = members;              //1.透過ViewData傳遞資料給View
            ViewBag.Members = members;                    //2.透過ViewBag傳遞資料給View
            return View(members);                       //3.透過Model將model物件資料傳給View
        }
        public IActionResult ListDB()
        {
            MemberContext context = new MemberContext();
            var members = context.Members.ToList();

            string jsonMembers = JsonConvert.SerializeObject(members);

            ViewData["jsonMembers"] = jsonMembers;

            return View();
        }
        public async Task<IActionResult>ListTable()
        {
            MemberContext ctx = new MemberContext();

            var members = await ctx.Members.ToListAsync();


            return View(members);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            if(id==0)
            {
                return Content("請提供Id編號");
            }

            MemberContext ctx = new MemberContext();

            var member =await ctx.Members.FindAsync(id);

            if(member==null)
            {
                return Content("找不到此Id員工");
            }
            return View(member);
        }
    }
}
