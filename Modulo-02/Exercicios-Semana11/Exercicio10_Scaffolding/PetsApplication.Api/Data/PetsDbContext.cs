using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using PetsApplication.Api.Models;

namespace PetsApplication.Api.Data
{
    public partial class PetsDbContext : DbContext
    {
        public PetsDbContext()
        {
        }

        public PetsDbContext(DbContextOptions<PetsDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Pessoa> Pessoas { get; set; } = null!;
        public virtual DbSet<Pet> Pets { get; set; } = null!;
        public virtual DbSet<Raca> Racas { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=Pets;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Telefone)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasMany(d => d.Pets)
                    .WithMany(p => p.Pessoas)
                    .UsingEntity<Dictionary<string, object>>(
                        "PessoasPet",
                        l => l.HasOne<Pet>().WithMany().HasForeignKey("PetId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_PessoasPet_Pet"),
                        r => r.HasOne<Pessoa>().WithMany().HasForeignKey("PessoaId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_PessoasPet_Pessoa"),
                        j =>
                        {
                            j.HasKey("PessoaId", "PetId");

                            j.ToTable("PessoasPet");
                        });
            });

            modelBuilder.Entity<Pet>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Raca)
                    .WithMany(p => p.Pets)
                    .HasForeignKey(d => d.RacaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pets_Racaid");
            });

            modelBuilder.Entity<Raca>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
