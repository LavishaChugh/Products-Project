using Microsoft.EntityFrameworkCore;
using Products.Models;

namespace Products.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           // base.OnModelCreating(modelBuilder);

            
        }

        public DbSet<Item> Items { get; set; }

        public DbSet<Puchase> Puchases { get; set; }

        public DbSet<Stock> stocks { get; set; }


    }
}
