using Escola.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Escola.Infra.DataBase.Mappings;

public class NotasMateriaMap : IEntityTypeConfiguration<NotasMateria>
{
    public void Configure(EntityTypeBuilder<NotasMateria> builder)
    {
        builder.ToTable("NotasMateria");

        builder.HasKey(nm => nm.Id);

        builder.Property(nm => nm.Id)
                .HasColumnName("ID")
                .UseIdentityColumn()
                .ValueGeneratedOnAdd();

        builder.Property(nm => nm.Nota)
                .HasColumnName("NOTA")
                .HasColumnType("int");
        
        builder.HasOne(nm=>nm.Materia)
                .WithMany(m => m.NotasMaterias)
                .HasForeignKey(nm => nm.MateriaId)
                .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(nm => nm.Boletim)
                .WithMany(b => b.Notas)
                .HasForeignKey(nm => nm.BoletimId);
        
    }
}
