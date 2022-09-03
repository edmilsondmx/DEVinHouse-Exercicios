using Escola.Domain.Models;

namespace Escola.Domain.Interfaces.Repositories;

public interface IBoletimRepositorio
{
    IList<Boletim> ObterTodos(Paginacao paginacao);
    Boletim ObterPorId(int id);
    void Inserir(Boletim boletim);
    void Excluir (Boletim boletim);
    void Alterar (Boletim boletim);
    bool ExisteMatricula(int matricula);
    int ObterTotal();
}
