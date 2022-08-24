using Microsoft.EntityFrameworkCore;
using PatrimonioSenaiTag.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PatrimonioSenaiTag.EntityConfiguration;

public class NivelConfiguration : IEntityTypeConfiguration<Nivel>
 {
    public void Configure(EntityTypeBuilder<Nivel> builder)
    {
        builder.ToTable("Nivel");
        builder.HasKey(n => n.Id);
        builder.Property(n => n.Nome)
                .IsRequired()
                .HasMaxLength(80);
        builder.HasMany(n => n.Usuarios)
               .WithOne(u => u.Nivel)
               .HasForeignKey(u => u.NivelId);
    }
}