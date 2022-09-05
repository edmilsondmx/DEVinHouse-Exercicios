using Escola.Domain.DTO;

namespace Escola.Domain.Models;

public class NotasMateria
{
    public int Id { get; set; }
    public int Nota { get; set; }
    public int MateriaId { get; set; }
    public int BoletimId { get; set; }
    public virtual Materia Materia { get; set; }
    public virtual Boletim Boletim { get; set; }

    public NotasMateria(NotasMateriaDTO notasMateria)
    {
        Id = notasMateria.Id;
        Nota = notasMateria.Nota;
        MateriaId = notasMateria.MateriaId;
        BoletimId = notasMateria.BoletimId;
    }
    public NotasMateria()
    {
        
    }
    public void Uptade(NotasMateriaDTO notasMateria)
    {
        Nota = notasMateria.Nota;
        MateriaId = notasMateria.MateriaId;
        BoletimId = notasMateria.BoletimId;
    }
}
