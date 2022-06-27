using Microsoft.AspNetCore.Mvc;
using _0624_ReBuild_CoreMvc5_Razor.Models;
using System.Collections.Generic;
using _0624_ReBuild_CoreMvc5_Razor.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace _0624_ReBuild_CoreMvc5_Razor.Controllers
{

    public class RazorScoresController : Controller
    {
        //private readonly List<Student> _students;

        //public RazorScoresController()
        //{
        //    _students = new List<Student>()
        //    {
        //        new Student{Id=1,Name="Joe",Chinese=88,English=95,Math=71},
        //        new Student{Id=12,Name="Aoe",Chinese=88,English=95,Math=71},
        //        new Student{Id=11,Name="Eoe",Chinese=88,English=95,Math=71},
        //        new Student{Id=14,Name="Voe",Chinese=88,English=95,Math=71},
        //        new Student{Id=16,Name="Doe",Chinese=88,English=95,Math=71},

        //    };

        //}
        private readonly StudentContext _context;
        private readonly List<Student> _students;

        public RazorScoresController(StudentContext context)
        {
            _context = context;

            _students = new List<Student>()
            {
                new Student{Id=1,Name="Joe",Chinese=88,English=95,Math=71},
                new Student{Id=12,Name="Aoe",Chinese=88,English=95,Math=71},
                new Student{Id=11,Name="Eoe",Chinese=88,English=95,Math=71},
                new Student{Id=14,Name="Voe",Chinese=88,English=95,Math=71},
                new Student{Id=16,Name="Doe",Chinese=88,English=95,Math=71},

                };
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Scores()
        {
            return View(_students);
        }
        public async Task<IActionResult> ScoresDB()
        {
            return View(await _context.Students.ToListAsync());
        }
        public async Task<IActionResult> AppendData()
        {
            List<Student> studentsPart2 = new List<Student>()
            {
                new Student{Name="uoe",Chinese=88,English=95,Math=71},
                new Student{Name="loe",Chinese=88,English=95,Math=71},
            };

            await _context.Students.AddRangeAsync(studentsPart2);
            await _context.SaveChangesAsync();

            return RedirectToAction("ScoresDB");
        }
    }
}
