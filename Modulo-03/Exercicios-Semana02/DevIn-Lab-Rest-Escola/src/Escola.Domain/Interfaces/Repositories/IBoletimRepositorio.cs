using Escola.Domain.Models;

namespace Escola.Domain.Interfaces.Repositories;

public interface IBoletimRepositorio
{
    IList<Boletim> ObterTodos(Paginacao paginacao);
    Boletim ObterPorId(int id);
    void Inserir(Boletim boletim);
    void ExcluirMateria(Boletim boletim, NotasMateria materia);
    void Alterar (Boletim boletim);
    int ObterTotal();
}
