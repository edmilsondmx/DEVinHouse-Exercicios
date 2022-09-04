using Escola.Domain.DTO;
using Escola.Domain.Models;

namespace Escola.Domain.Interfaces.Services;

public interface IMateriaServico
{
    IList<MateriaDTO> ObterTodos();
    MateriaDTO ObterPorId(int id);
    IList<MateriaDTO> ObterPorNome(string nome);
    void Inserir(MateriaDTO boletim);
    void ExcluirMateria (int boletimId, int materiaId);
    void Alterar (MateriaDTO boletim, int id);
}
