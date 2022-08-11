using Microsoft.EntityFrameworkCore;
using MusicApplication.Api.Models;

namespace MusicApplication.Api.Data;

public class MusicDbContext : DbContext
{
    private readonly IConfiguration _configuration;

    public MusicDbContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public DbSet<Artista> Artistas { get; set; } 
    public DbSet<Musica> Musicas { get; set; } 
    public DbSet<Album> Albuns { get; set; } 

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        optionsBuilder.UseSqlServer(
            _configuration.GetConnectionString("ConexaoBanco")
        );
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        //Artista
        modelBuilder.Entity<Artista>()
            .ToTable("Artistas");

        modelBuilder.Entity<Artista>()
            .HasKey(a => a.Id);

        modelBuilder.Entity<Artista>()
            .Property(a => a.Nome)
            .HasMaxLength(50)
            .IsRequired();
        
        modelBuilder.Entity<Artista>()
            .Property(a => a.NomeArtistico)
            .HasMaxLength(50)
            .IsRequired();
        
        modelBuilder.Entity<Artista>()
            .Property(a => a.PaisOrigem)
            .HasMaxLength(20);
        
        //Musica
        modelBuilder.Entity<Musica>()
            .ToTable("Musicas");

        modelBuilder.Entity<Musica>()
            .HasKey(m => m.Id);
        
        modelBuilder.Entity<Musica>()
            .Property(m => m.Nome)
            .HasMaxLength(200)
            .IsRequired();

        modelBuilder.Entity<Musica>()
            .Property(m => m.Duracao);

        modelBuilder.Entity<Musica>()
            .HasOne<Artista>(m => m.Artista)
            .WithMany(a => a.Musicas)
            .HasForeignKey(m => m.ArtistaId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Musica>()
            .HasOne<Album>(m => m.Album)
            .WithMany(a => a.Musicas)
            .HasForeignKey(m => m.AlbumId)
            .OnDelete(DeleteBehavior.Restrict);

        //Album
        modelBuilder.Entity<Album>()
            .ToTable("Albuns");

        modelBuilder.Entity<Album>()
            .HasKey(a => a.Id);
        
        modelBuilder.Entity<Album>()
            .Property(a => a.Nome)
            .HasMaxLength(200)
            .IsRequired();

        modelBuilder.Entity<Album>()
            .Property(a => a.Ano);

        modelBuilder.Entity<Album>()
            .HasOne<Artista>(album => album.Artista)
            .WithMany(artista => artista.Albuns)
            .HasForeignKey(album => album.ArtistaId)
            .OnDelete(DeleteBehavior.Restrict);

    }
}
