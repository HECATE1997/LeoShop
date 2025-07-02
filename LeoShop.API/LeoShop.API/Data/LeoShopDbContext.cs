using LeoShop.OrderManagement.Models;
using LeoShop.PaymentGateway.Models;
using LeoShop.ProductCatalog.Models;
using Microsoft.EntityFrameworkCore;
using LeoShop.UserManagement.Models;

namespace LeoShop.API.Data
{
    public class LeoShopDbContext : DbContext
    {
        public LeoShopDbContext(DbContextOptions<LeoShopDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Payment> Payments { get; set; }
    }
}
