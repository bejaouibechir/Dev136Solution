using Microsoft.EntityFrameworkCore;

namespace WebMVCEFInMemory.Models
{
    public class ProductContext:DbContext
    {

        public ProductContext(DbContextOptions<ProductContext> options):base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase(databaseName: "Products");
        }


        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
