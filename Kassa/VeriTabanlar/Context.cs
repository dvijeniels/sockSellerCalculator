using System.Data.Entity;

namespace Kassa.VeriTabanlar
{
    class Context:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Sold> Solds { get; set; }
    }
}
