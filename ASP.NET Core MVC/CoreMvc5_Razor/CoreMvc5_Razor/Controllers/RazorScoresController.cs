using Microsoft.AspNetCore.Mvc;
using CoreMvc5_Razor.Models;
using System.Collections.Generic;

namespace CoreMvc5_Razor.Controllers
{
    public class RazorScoresController : Controller
    {
        private readonly List<Student> _students;
        public RazorScoresController()
        {
            _students = new List<Student>()
            {
                new Student { Id =1, Name="Joe", Chinese=88, English=95, Math=71 },
                new Student { Id =12, Name="Mary", Chinese=92, English=82, Math=60 },
                new Student { Id =23, Name="Cathy", Chinese=98, English=91, Math=94 },
                new Student { Id =34, Name="John", Chinese=63, English=85, Math=55 },
                new Student { Id =45, Name="David", Chinese=59, English=77, Math=82 }
            };
        }

        public IActionResult Scores()
        {
            return View(_students);

            //return Json(_students);
        }

        public IActionResult Index()
        {
            return View();
        }


    }
}
