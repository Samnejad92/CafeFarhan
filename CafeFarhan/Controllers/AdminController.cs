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
    }
}