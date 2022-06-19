using CoreMvc5_Pillars_Clone.Models;
using CoreMvc5_Pillars_Clone.ViewsModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreMvc5_Pillars_Clone.Controllers
{
    public class ClothingController : Controller
    {
        private readonly List<Clothing> _clothData;

        public ClothingController()
        {
            _clothData = new List<Clothing>
            {
                new Clothing{Id= 1,Name="Bra圓領連袖T恤-女",Price=350,Photo="https://s1.lativ.com.tw/i/56213/56213_M_01_n.jpg"},
                new Clothing{Id= 2,Name="抗UV輕型防水長外套-女",Price=990,Photo="https://s2.lativ.com.tw/i/TagPicture/56342/56342_M_02_tag_n.jpg"},
                new Clothing{Id= 3,Name="文字寬版印花T恤-02-女",Price=266,Photo="https://s3.lativ.com.tw/i/57276/57276_M_02_n.jpg"},
            };
        }

        public IActionResult Index()
        {
            //Data Model-模擬SQL Server資料庫
            List<Clothing> clothes = new List<Clothing>
            {
                new Clothing{Id= 1,Name="Bra圓領連袖T恤-女",Price=350,Photo="https://s1.lativ.com.tw/i/56213/56213_M_01_n.jpg"},
                new Clothing{Id= 2,Name="抗UV輕型防水長外套-女",Price=990,Photo="https://s2.lativ.com.tw/i/TagPicture/56342/56342_M_02_tag_n.jpg"},
                new Clothing{Id= 3,Name="文字寬版印花T恤-02-女",Price=266,Photo="https://s3.lativ.com.tw/i/57276/57276_M_02_n.jpg"},
            };

            List<ClothingViewModel>clothingViewModel=new List<ClothingViewModel>();
            //View Model
            foreach(var item in clothes)
            {
                clothingViewModel.Add(new ClothingViewModel
                { Id=item.Id, ProductName = item.Name, UnitPrice = item.Price, ProductPhoto = item.Photo });
            }
            return View(clothingViewModel);
        }
        public IActionResult Details(int? id)
        {
            var cloth = _clothData.Find(x=>x.Id == id);
            return View(cloth);
        }
    }
}
