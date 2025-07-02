using LeoShop.OrderManagement.Models;
using LeoShop.PaymentGateway.Models;
using LeoShop.ProductCatalog.Models;
using LeoShop.UserManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace LeoShop.API.Data
{
    public class LeoShopCosmosDbContext : DbContext
    {
        public LeoShopCosmosDbContext(DbContextOptions<LeoShopCosmosDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseCosmos(
                "https://your-cosmos-db-uri.com",
                "YourCosmosDbKey==",
                "YourDatabaseName");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Payment> Payments { get; set; }
    }

}
