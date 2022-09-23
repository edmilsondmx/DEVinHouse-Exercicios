using Banda.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Banda.Infra.DataBase.Mappings;

public class TocarMap : IEntityTypeConfiguration<Tocar>
{
    public void Configure(EntityTypeBuilder<Tocar> builder)
    {
        builder.ToTable("TOCAR");

        builder.HasKey(t => t.Id);

        builder.Property(t => t.Id)
                .HasColumnName("ID")
                .HasColumnType("uniqueidentifier");

        builder.Property(t => t.Descrição)
                .HasColumnName("DESCRICAO")
                .HasColumnType("VARCHAR")
                .HasMaxLength(200);

        builder.Property(t => t.NomeMusica)
                .HasColumnName("NOME_MUSICA")
                .HasColumnType("VARCHAR")
                .HasMaxLength(50);

        builder.Property(t => t.SequenciaMusica)
                .HasColumnName("SEQUENCIA_MUSICA")
                .HasColumnType("int");
    }
}
