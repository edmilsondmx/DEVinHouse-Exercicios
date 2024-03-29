using Escola.Domain.Models;

namespace Escola.Domain.DTO;

public class MateriaDTO : BaseHateoasDTO
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public MateriaDTO(Materia materia)
    {
        Id = materia.Id;
        Nome = materia.Nome;
    }
    public MateriaDTO(MateriaV2DTO materia)
    {
        Id = materia.Id;
        Nome = materia.Diciplina;
    }

    public MateriaDTO()
    {
        
    }
}
