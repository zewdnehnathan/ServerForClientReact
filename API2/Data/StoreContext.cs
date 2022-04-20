using API2.Entities;
using Microsoft.EntityFrameworkCore;

namespace API2.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    
        public DbSet<Basket> Baskets { get; set; }
    
    }
}
