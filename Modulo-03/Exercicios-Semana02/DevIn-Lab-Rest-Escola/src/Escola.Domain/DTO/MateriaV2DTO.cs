using Escola.Domain.Models;

namespace Escola.Domain.DTO;

public class MateriaV2DTO
{
    public int Id { get; set; }
    public string Diciplina { get; set; }
    public MateriaV2DTO(Materia materia)
    {
        Id = materia.Id;
        Diciplina = materia.Nome;
    }
    public MateriaV2DTO(MateriaDTO materia)
    {
        Id = materia.Id;
        Diciplina = materia.Nome;
    }

    public MateriaV2DTO()
    {
        
    }
}
