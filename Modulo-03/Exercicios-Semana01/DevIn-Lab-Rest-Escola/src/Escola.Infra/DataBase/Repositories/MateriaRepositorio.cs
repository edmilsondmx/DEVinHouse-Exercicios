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
    public void Alterar(Materia boletim, int id)
    {
        throw new NotImplementedException();
    }

    public void ExcluirMateria(int boletimId, int materiaId)
    {
        throw new NotImplementedException();
    }

    public void Inserir(Materia boletim)
    {
        throw new NotImplementedException();
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
