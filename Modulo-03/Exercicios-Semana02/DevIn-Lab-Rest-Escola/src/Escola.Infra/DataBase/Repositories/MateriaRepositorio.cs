using Escola.Domain.Interfaces.Repositories;
using Escola.Domain.Models;

namespace Escola.Infra.DataBase.Repositories;

public class MateriaRepositorio : BaseRepositorio<Materia, int>, IMateriaRepositorio
{
    public MateriaRepositorio(EscolaDBContexto contexto) : base(contexto)
    {
    }

    public IList<Materia> ObterPorNome(string nome)
    {
        return _contexto.Materias
            .Where(m => m.Nome
            .Contains(nome))
            .ToList();
    }
}
