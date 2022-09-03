using Escola.Domain.DTO;
using Escola.Domain.Models;

namespace Escola.Domain.Interfaces.Services;

public interface IBoletimServico
{
    IList<BoletimDTO> ObterTodos(Paginacao paginacao);
    BoletimDTO ObterPorId(int id);
    IList<BoletimDTO> ObterPorIdAluno(Guid id, Paginacao paginacao);
    IList<BoletimDTO> ObterPorNome(string nome, Paginacao paginacao);
    void Inserir(BoletimDTO boletim);
    void ExcluirMateria (int boletimId, int materiaId);
    void Alterar (BoletimDTO boletim, int id);
    int ObterTotal();
}
