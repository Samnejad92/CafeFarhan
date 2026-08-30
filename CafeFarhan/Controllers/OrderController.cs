using CafeFarhan.Data;
using CafeFarhan.Models;
using Microsoft.AspNetCore.Mvc;

namespace CafeFarhan.Controllers
{
    [Route("[controller]/[action]")]
    public class OrderController : Controller
    {
        private readonly CafeDbContext _context;

        public OrderController(CafeDbContext context)
        {
            _context = context;
        }


        [HttpPost]
        public async Task<IActionResult> Create(
            [FromBody] CreateOrderRequest request)
        {
            if (request == null ||
                request.Items == null ||
                request.Items.Count == 0)
            {
                return BadRequest();
            }


            var productIds =
                request.Items
                    .Select(x => x.ProductId)
                    .ToList();


            var products =
                _context.Products
                    .Where(x =>
                        productIds.Contains(x.Id) &&
                        x.IsAvailable)
                    .ToList();


            var order = new Order
            {
                TableNumber = request.TableNumber,

                Status = OrderStatus.New,

                CreatedAt = DateTime.Now
            };


            decimal total = 0;


            foreach (var item in request.Items)
            {
                var product =
                    products.FirstOrDefault(
                        x => x.Id == item.ProductId
                    );


                if (product == null)
                    continue;


                var quantity =
                    Math.Max(1, item.Quantity);


                var orderItem = new OrderItem
                {
                    ProductId = product.Id,

                    ProductName = product.Name,

                    Quantity = quantity,

                    UnitPrice = product.Price
                };


                order.Items.Add(orderItem);

                total +=
                    product.Price * quantity;
            }


            order.TotalPrice = total;


            _context.Orders.Add(order);

            await _context.SaveChangesAsync();


            return Json(new
            {
                success = true,

                orderId = order.Id
            });
        }
    }


    public class CreateOrderRequest
    {
        public int TableNumber { get; set; }

        public List<OrderRequestItem> Items { get; set; }
            = new();
    }


    public class OrderRequestItem
    {
        public int ProductId { get; set; }

        public int Quantity { get; set; }
    }
}