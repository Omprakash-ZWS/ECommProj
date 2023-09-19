using E_Commerece.DomainModel.Model;
using Microsoft.EntityFrameworkCore;

namespace E_Commerece.Context
{
    public class ECommDbContext : DbContext
    {
        public ECommDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Category> categories { get; set; }
        public DbSet<Product> products{ get; set; }
    }
}
