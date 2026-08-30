using CafeFarhan.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CafeFarhan.Controllers
{
    public class MenuController : Controller
    {
        private readonly CafeDbContext _context;

        public MenuController(CafeDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int? table)
        {
            var categories = await _context.Categories
                .Include(x => x.Products)
                .OrderBy(x => x.DisplayOrder)
                .ToListAsync();

            ViewBag.TableNumber = table ?? 0;

            return View(categories);
        }
    }
}