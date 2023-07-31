using Microsoft.EntityFrameworkCore;
using PropertyStore.Models;

namespace PropertyStore.DBData
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public DbSet<Item> Items { get; set; }


    }
}
