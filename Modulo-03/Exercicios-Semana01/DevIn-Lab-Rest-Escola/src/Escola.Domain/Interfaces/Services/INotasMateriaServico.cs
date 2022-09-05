using Escola.Domain.DTO;

namespace Escola.Domain.Interfaces.Services;

public interface INotasMateriaServico
{
    IList<NotasMateriaDTO> ObterTodos();
    NotasMateriaDTO ObterPorId(int id);
    IList<NotasMateriaDTO> ObterPorBoletim(Guid alunoId, int boletimId);
    void Inserir(NotasMateriaDTO notasMateria);
    void Excluir(int notasMateriaId);
    void Alterar (NotasMateriaDTO notasMateria);

}
