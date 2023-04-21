using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebMVCCodeFirst.Models
{
    internal class StoreConfig : IEntityTypeConfiguration<Store>
    {
        public void Configure(EntityTypeBuilder<Store> builder)
        {
            //Pour créer la table avec le nom model
            builder.ToTable("Stores");
            //Pour créer la colonne Id avec une contrainte de clé primaire
            builder.HasKey(model => model.Id);
            builder.Property(model => model.Id).ValueGeneratedNever();

            //Pour créer une colonne nvarchar(50)
            builder.Property(model => model.Name).HasMaxLength(50);

            //Pour créer une colonne nvarchar(50)
            builder.Property(model => model.City).HasMaxLength(20);

            //Definition de la relation de 1 responsable  à plusieurs stores
            builder.HasOne(d => d.Responsible).WithMany(p => p.Stores)
               .HasForeignKey(d => d.ResponsableId)
               .OnDelete(DeleteBehavior.SetNull)
               .HasConstraintName("FK_Store_Responsible");

        }
    }
}