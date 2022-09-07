using Escola.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Escola.Infra.DataBase.Mappings;

public class BoletimMap : IEntityTypeConfiguration<Boletim>
{
    public void Configure(EntityTypeBuilder<Boletim> builder)
    {
        builder.ToTable("BOLETIM");

        builder.HasKey(b => b.Id);
        
        builder.Property(b => b.Id)
                .HasColumnName("ID")
                .UseIdentityColumn()
                .ValueGeneratedOnAdd();

        builder.Property(b => b.Periodo)
                .HasColumnName("PERIODO")
                .HasColumnType("VARCHAR")
                .HasMaxLength(10);
        
        builder.Property(b => b.Faltas)
                .HasColumnName("FALTAS")
                .HasColumnType("int");
        
        builder
                .HasOne(b => b.Aluno)
                .WithMany(a => a.Boletins)
                .HasForeignKey(b => b.AlunoId);
        
        builder
                .HasMany(b => b.Notas)
                .WithOne(n => n.Boletim);
    }
}
