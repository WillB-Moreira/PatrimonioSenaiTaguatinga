using Microsoft.EntityFrameworkCore;
using PatrimonioSenaiTaguatinga.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PatrimonioSenaiTaguatinga.EntityConfiguration;

public class NivelConfiguration : IEntityTypeConfiguration<Nivel>
 {
    public void Configure(EntityTypeBuilder<Nivel> builder)
    {
        builder.ToTable("Nivel");
        builder.HasKey(n => n.Id);
        builder.Property(n => n.Nome)
                .IsRequired()
                .HasMaxLength(80);
        
    }
}