using Microsoft.EntityFrameworkCore;
using Items.Entities;
using Items.Interfaces;
namespace ItemCFTask.Context
{
    public class DbContextItems:DbContext
    {
        public DbContextItems(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<MyItems> Items { get; set; }
    }

}
