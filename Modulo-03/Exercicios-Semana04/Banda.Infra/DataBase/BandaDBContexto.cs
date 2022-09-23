using Banda.Domain.Models;
using Banda.Infra.DataBase.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Banda.Infra.DataBase;

public class BandaDBContexto : DbContext
{
    private readonly IConfiguration _configuration;
    public BandaDBContexto(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public DbSet<Tocar> Tocadas {get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        base.OnConfiguring(options);

        options.UseSqlServer(
            _configuration.GetConnectionString("ConexaoBanco")
        );
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration(new TocarMap());
    }
}
