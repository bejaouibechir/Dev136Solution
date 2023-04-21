using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebMVCCodeFirst.Models
{
    internal class ModelConfig : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            //Pour créer la table avec le nom model
            builder.ToTable("Models");
            //Pour créer la colonne Id avec une contrainte de clé primaire
            builder.HasKey(model => model.Id);
            builder.Property(model => model.Id).ValueGeneratedNever();

            //Pour créer une colonne nvarchar(50)
            builder.Property(model => model.Label).HasMaxLength(50);

        }
    }
}