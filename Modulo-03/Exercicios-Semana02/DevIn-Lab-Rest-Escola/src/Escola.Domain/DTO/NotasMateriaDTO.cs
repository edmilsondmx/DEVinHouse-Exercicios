using Escola.Domain.Models;

namespace Escola.Domain.DTO;

public class NotasMateriaDTO
{
    public int Id { get; set; }
    public int Nota { get; set; }
    public int MateriaId { get; set; }
    public int BoletimId { get; set; }

    public NotasMateriaDTO(NotasMateria notasMateria)
    {
        Id = notasMateria.Id;
        Nota = notasMateria.Nota;
        MateriaId = notasMateria.MateriaId;
        BoletimId = notasMateria.BoletimId;
    }
    public NotasMateriaDTO()
    {
        
    }
}
