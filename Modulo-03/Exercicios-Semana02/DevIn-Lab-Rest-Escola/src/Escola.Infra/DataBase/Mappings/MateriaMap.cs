using Escola.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Escola.Infra.DataBase.Mappings;

public class MateriaMap : IEntityTypeConfiguration<Materia>
{
    public void Configure(EntityTypeBuilder<Materia> builder)
    {
        builder.ToTable("MATERIA");

        builder.HasKey(m => m.Id);

        builder.Property(m => m.Id)
                .HasColumnName("ID")
                .UseIdentityColumn()
                .ValueGeneratedOnAdd();

        builder.Property(m => m.Nome)
                .HasColumnName("NOME")
                .HasColumnType("VARCHAR")
                .HasMaxLength(50);
    }
}
