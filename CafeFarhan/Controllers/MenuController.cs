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


        [HttpGet]
        public async Task<IActionResult> Index(int? table)
        {
            var categories = await _context.Categories
                .Include(x => x.Products)
                .OrderBy(x => x.DisplayOrder)
                .ToListAsync();


            // اگر از QR آمده باشد
            if (table.HasValue && table.Value > 0)
            {
                ViewBag.TableNumber =
                    table.Value;

                ViewBag.IsDirectOrder = false;
            }
            else
            {
                // ورود مستقیم
                ViewBag.TableNumber = 0;

                ViewBag.IsDirectOrder = true;
            }


            return View(categories);
        }
    }
}