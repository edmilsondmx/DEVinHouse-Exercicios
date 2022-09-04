using Escola.Domain.Interfaces.Repositories;
using Escola.Domain.Models;

namespace Escola.Infra.DataBase.Repositories;

public class MateriaRepositorio : IMateriaRepositorio
{
    private readonly EscolaDBContexto _contexto;
    public MateriaRepositorio(EscolaDBContexto contexto)
    {
        _contexto = contexto;
    }
    public void Alterar(Materia materia)
    {
        _contexto.Update(materia);
        _contexto.SaveChanges();
    }

    public void Excluir(Materia materia)
    {
        _contexto.Materias.Remove(materia);
        _contexto.SaveChanges();
    }

    public void Inserir(Materia materia)
    {
        _contexto.Materias.Add(materia);
        _contexto.SaveChanges();
    }

    public Materia ObterPorId(int id)
    {
        return _contexto.Materias.Find(id);
    }

    public IList<Materia> ObterPorNome(string nome)
    {
        return _contexto.Materias
            .Where(m => m.Nome
            .Contains(nome))
            .ToList();
    }

    public IList<Materia> ObterTodos()
    {
        return _contexto.Materias.ToList();
    }
}
