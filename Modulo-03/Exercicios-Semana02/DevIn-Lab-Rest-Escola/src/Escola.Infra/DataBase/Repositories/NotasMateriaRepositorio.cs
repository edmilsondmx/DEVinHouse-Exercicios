using Escola.Domain.Interfaces.Repositories;
using Escola.Domain.Models;

namespace Escola.Infra.DataBase.Repositories;

public class NotasMateriaRepositorio : BaseRepositorio<NotasMateria, int>, INotasMateriaRepositorio
{
    public NotasMateriaRepositorio(EscolaDBContexto contexto) : base(contexto)
    {
    }

    public IList<NotasMateria> ObterTodos()
    {
        return _contexto.NotasMaterias.ToList();
    }
}
