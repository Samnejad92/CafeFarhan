using CafeFarhan.Data;
using CafeFarhan.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CafeFarhan.Controllers
{
    [Route("Admin")]
    public class AdminController : Controller
    {
        private readonly CafeDbContext _context;

        public AdminController(CafeDbContext context)
        {
            _context = context;
        }

        [HttpGet("Orders")]
        public IActionResult Orders()
        {
            return View();
        }

        [HttpGet("Products")]
        public async Task<IActionResult> Products()
        {
            var products = await _context.Products
                .Include(p => p.Category)
                .OrderBy(p => p.Category.DisplayOrder)
                .ThenBy(p => p.Name)
                .ToListAsync();

            return View(products);
        }

        [HttpGet("EditProduct/{id}")]
        public async Task<IActionResult> EditProduct(int id)
        {
            var product = await _context.Products
                .FirstOrDefaultAsync(p => p.Id == id);

            if (product == null)
                return NotFound();

            ViewBag.Categories = await _context.Categories
                .OrderBy(c => c.DisplayOrder)
                .ToListAsync();

            return View(product);
        }

        [HttpPost("EditProduct/{id}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditProduct(
            int id,
            Product model)
        {
            var product = await _context.Products
                .FirstOrDefaultAsync(p => p.Id == id);

            if (product == null)
                return NotFound();

            if (!ModelState.IsValid)
            {
                ViewBag.Categories = await _context.Categories
                    .OrderBy(c => c.DisplayOrder)
                    .ToListAsync();

                return View(model);
            }

            product.Name = model.Name;
            product.Description = model.Description;
            product.Ingredients = model.Ingredients;
            product.Price = model.Price;
            product.ImageUrl = model.ImageUrl;
            product.CategoryId = model.CategoryId;
            product.IsAvailable = model.IsAvailable;

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Products));
        }

        [HttpGet("PrintOrder/{id}")]
        public async Task<IActionResult> PrintOrder(int id)
        {
            var order = await _context.Orders
                .Include(x => x.Items)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (order == null)
                return NotFound();

            return View(order);
        }

        [HttpGet("GetOrders")]
        public async Task<IActionResult> GetOrders()
        {
            var orders = await _context.Orders
    .Include(x => x.Items)
    .Where(x =>
        x.Status == OrderStatus.New ||
        x.Status == OrderStatus.Preparing ||
        x.Status == OrderStatus.Ready ||
        x.CreatedAt >= DateTime.Now.AddHours(-2)
    )
    .OrderByDescending(x => x.CreatedAt)
    .Select(x => new
    {
        id = x.Id,
        tableNumber = x.TableNumber,
        totalPrice = x.TotalPrice,
        status = (int)x.Status,
        createdAt = x.CreatedAt,

        items = x.Items.Select(i => new
        {
            productName = i.ProductName,
            quantity = i.Quantity,
            unitPrice = i.UnitPrice
        })
    })
    .ToListAsync();

            return Json(orders);
        }

        [HttpPost("ChangeStatus")]
        public async Task<IActionResult> ChangeStatus(
            int id,
            OrderStatus status)
        {
            var order = await _context.Orders
                .FindAsync(id);

            if (order == null)
                return NotFound();

            order.Status = status;

            await _context.SaveChangesAsync();

            return Json(new
            {
                success = true
            });
        }

        [HttpGet("Categories")]
        public async Task<IActionResult> Categories()
        {
            var categories = await _context.Categories
                .Include(c => c.Products)
                .OrderBy(c => c.DisplayOrder)
                .ToListAsync();

            return View(categories);
        }

        [HttpGet("AddCategory")]
        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpPost("AddCategory")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddCategory(Category model)
        {
            if (!ModelState.IsValid)
                return View(model);

            _context.Categories.Add(model);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Categories));
        }

        [HttpGet("EditCategory/{id}")]
        public async Task<IActionResult> EditCategory(int id)
        {
            var category = await _context.Categories
                .FirstOrDefaultAsync(c => c.Id == id);

            if (category == null)
                return NotFound();

            return View(category);
        }

        [HttpPost("EditCategory/{id}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditCategory(
            int id,
            Category model)
        {
            if (id != model.Id)
                return BadRequest();

            if (!ModelState.IsValid)
                return View(model);

            var category = await _context.Categories
                .FirstOrDefaultAsync(c => c.Id == id);

            if (category == null)
                return NotFound();

            category.Name = model.Name;
            category.DisplayOrder = model.DisplayOrder;

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Categories));
        }

    }
}
