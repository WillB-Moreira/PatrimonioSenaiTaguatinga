using Microsoft.EntityFrameworkCore;
using PatrimonioSenaiTaguatinga.Entities;
using PatrimonioSenaiTaguatinga.EntityConfiguration;

namespace PatrimonioSenaiTaguatinga.Contexts;

public class PatrimonioContext : DbContext
{
    private readonly IConfiguration _configuration;

    public PatrimonioContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    public DbSet<Nivel> Nivel => Set<Nivel>();
    public DbSet<Usuario> Usuarios => Set<Usuario>();

    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_configuration.GetConnectionString("Patrimonio"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new NivelConfiguration());
        modelBuilder.ApplyConfiguration(new UsuarioConfiguration());

    }
  
}
