using Microsoft.EntityFrameworkCore;
using Pierwszy__prodzekt.Models;

namespace Pierwszy__prodzekt
{
    public class DbTestContext : DbContext
    {
        public DbTestContext(DbContextOptions<DbTestContext> options) : base(options) { }


        public DbSet<Product> Products { get; set; }







        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
    
}
