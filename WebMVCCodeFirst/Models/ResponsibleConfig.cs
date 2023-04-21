using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebMVCCodeFirst.Models;

namespace WebMVCCodeFirst.Models
{
    internal class ResponsibleConfig : IEntityTypeConfiguration<Responsible>
    {
        public void Configure(EntityTypeBuilder<Responsible> builder)
        {
            builder.ToTable("Responsibles");
            //Pour créer la colonne Id avec une contrainte de clé primaire
            builder.HasKey(resp => resp.Id);
            builder.Property(resp => resp.Id).ValueGeneratedNever();

            //Pour créer une colonne nvarchar(50)
            builder.Property(resp => resp.Nom).HasMaxLength(50);
        }
    }
}