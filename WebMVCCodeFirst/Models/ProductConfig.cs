using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebMVCCodeFirst.Models
{
    internal class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedNever();

            builder.Property(p => p.Discount).HasColumnType("money");
            builder.Property(p => p.Name).HasMaxLength(50);
            builder.Property(p => p.Price).HasColumnType("money");

            builder.HasOne(m => m.Model).WithMany(p => p.Products)
                .HasForeignKey(m => m.ModelId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_Product_Model");

            builder.HasOne(s => s.Store).WithMany(p => p.Products)
                .HasForeignKey(s => s.StoreId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_Product_Store");







        }
    }
}