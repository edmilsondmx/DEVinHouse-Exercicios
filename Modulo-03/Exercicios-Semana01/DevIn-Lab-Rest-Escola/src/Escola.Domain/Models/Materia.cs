using Escola.Domain.DTO;

namespace Escola.Domain.Models;

public class Materia
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public virtual List<NotasMateria> NotasMaterias { get; set; }

    public Materia(MateriaDTO materia)
    {
        Nome = materia.Nome;
    }
    public Materia()
    {
        
    }
}
