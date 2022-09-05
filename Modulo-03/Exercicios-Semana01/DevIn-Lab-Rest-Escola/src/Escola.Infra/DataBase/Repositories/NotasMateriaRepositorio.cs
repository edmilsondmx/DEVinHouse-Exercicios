using Escola.Domain.Interfaces.Repositories;
using Escola.Domain.Models;

namespace Escola.Infra.DataBase.Repositories;

public class NotasMateriaRepositorio : INotasMateriaRepositorio
{
    private readonly EscolaDBContexto _contexto;
    public NotasMateriaRepositorio(EscolaDBContexto contexto)
    {
        _contexto = contexto;
    }

    public void Alterar(NotasMateria notasMateria, int notasMateriaId)
    {
        throw new NotImplementedException();
    }

    public void Excluir(int notasMateriaId)
    {
        throw new NotImplementedException();
    }

    public void Inserir(NotasMateria notasMateria)
    {
        throw new NotImplementedException();
    }

    public NotasMateria ObterPorId(int id)
    {
        return _contexto.NotasMaterias.Find(id);
    }

    public IList<NotasMateria> ObterTodos()
    {
        return _contexto.NotasMaterias.ToList();
    }
}
