using Microsoft.EntityFrameworkCore;
using PatrimonioSenaiTaguatinga.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PatrimonioSenaiTaguatinga.EntityConfiguration;

public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder.ToTable("Usuarios");
        builder.HasKey(u => u.Id);
        builder.Property(u => u.Nome)
               .IsRequired()
               .HasMaxLength(60);
        builder.Property(u => u.Sobrenome)
               .IsRequired()
               .HasMaxLength(60);
        builder.Property(u => u.Login)
               .IsRequired()
               .HasMaxLength(20);
        builder.Property(u => u.Senha)
               .IsRequired()
               .HasMaxLength(10);
        builder.Property(u => u.IdNivel)
               .IsRequired();
                   

        builder.HasOne(u=>u.Nivel).WithMany(n=>n.Usuarios).HasForeignKey(u=>u.IdNivel);
    }
}
