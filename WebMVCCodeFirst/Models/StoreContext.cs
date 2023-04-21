using Microsoft.EntityFrameworkCore;
using WebMVCCodeFirst.Models;


namespace WebMVCCodeFirst.Models
{
    public class StoreContext :DbContext
    {
        public StoreContext()
        {
            
        }

        public StoreContext(DbContextOptions<StoreContext> options):base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=PC2023\PC2023;TrustServerCertificate=true;Initial Catalog=StoreDB;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Fluent API 

            modelBuilder.ApplyConfiguration(new ModelConfig());
            modelBuilder.ApplyConfiguration(new ResponsibleConfig());
            modelBuilder.ApplyConfiguration(new StoreConfig());
            modelBuilder.ApplyConfiguration(new ProductConfig());


        }

        public DbSet<WebMVCCodeFirst.Models.Model> Model { get; set; }

        public DbSet<WebMVCCodeFirst.Models.Responsible> Responsible { get; set; }

        public DbSet<WebMVCCodeFirst.Models.Store> Store { get; set; }

        public DbSet<WebMVCCodeFirst.Models.Product> Product { get; set; }


    }
}
