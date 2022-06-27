using CoreMvc5_Bootstrap.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreMvc5_Bootstrap.Controllers
{
    public class BootstrapController : Controller
    {
        private readonly List<Carousel> _sliderList;
        public BootstrapController()
        {
            _sliderList = new List<Carousel>
            {
                new Carousel { Id=1, Title="馬爾地夫", Description="", Photo="Maldives.jpg" },
                new Carousel { Id=2, Title="加拿大", Description="", Photo="Canada.jpg" },
                new Carousel { Id=3, Title="溫哥華", Description="", Photo="Vancouver.jpg" },
            };
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Slider()
        {
            return View();
        }
    }
}
