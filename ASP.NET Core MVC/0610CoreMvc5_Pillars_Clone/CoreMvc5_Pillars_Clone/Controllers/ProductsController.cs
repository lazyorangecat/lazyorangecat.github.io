using Microsoft.AspNetCore.Mvc;
using CoreMvc5_Pillars_Clone.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace CoreMvc5_Pillars_Clone.Controllers
{
    public class ProductsController : Controller
    {
        public readonly NorthwindContext _context;
        public ProductsController(NorthwindContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var northwindContext = _context.Products.Include(p =>p.CategoryId);

            var result = _context.Products.FindAsync(1);
            return View(await northwindContext.ToListAsync());
            
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Category)
                .Include(p => p.Supplier)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);

        }
    }

}
