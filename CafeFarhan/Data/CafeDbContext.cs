using CafeFarhan.Models;
using Microsoft.EntityFrameworkCore;

namespace CafeFarhan.Data
{
    public class CafeDbContext : DbContext
    {
        public CafeDbContext(
            DbContextOptions<CafeDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories => Set<Category>();

        public DbSet<Product> Products => Set<Product>();

        public DbSet<Order> Orders => Set<Order>();

        public DbSet<OrderItem> OrderItems => Set<OrderItem>();
    }
}