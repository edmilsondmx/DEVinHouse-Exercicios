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

    public void Alterar(NotasMateria notasMateria)
    {
        _contexto.NotasMaterias.Update(notasMateria);
        _contexto.SaveChanges();
    }

    public void Excluir(NotasMateria notasMateria)
    {
        _contexto.NotasMaterias.Remove(notasMateria);
        _contexto.SaveChanges();
    }

    public void Inserir(NotasMateria notasMateria)
    {
        _contexto.NotasMaterias.Add(notasMateria);
        _contexto.SaveChanges();
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
