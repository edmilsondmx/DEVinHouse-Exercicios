using Escola.Domain.Models;

namespace Escola.Domain.Interfaces.Repositories;

public interface INotasMateriaRepositorio
{
    IList<NotasMateria> ObterTodos();
    NotasMateria ObterPorId(int id);
    void Inserir(NotasMateria notasMateria);
    void Excluir(int notasMateriaId);
    void Alterar (NotasMateria notasMateria, int notasMateriaId);
}
