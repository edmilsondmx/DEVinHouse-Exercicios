using Escola.Domain.Interfaces.Repositories;
using Escola.Domain.Models;

namespace Escola.Infra.DataBase.Repositories;

public class BoletimRepositorio : IBoletimRepositorio
{
    private readonly EscolaDBContexto _contexto;

    public BoletimRepositorio(EscolaDBContexto contexto)
    {
        _contexto = contexto;
    }
    public void Alterar(Boletim boletim)
    {
        _contexto.Update(boletim);
        _contexto.SaveChanges();
    }

    public void ExcluirMateria(Boletim boletim, NotasMateria materia)
    {
        boletim.Notas.Remove(materia);
        _contexto.SaveChanges();
    }

    public bool ExisteMatricula(int matricula)
    {
        throw new NotImplementedException();
    }

    public void Inserir(Boletim boletim)
    {
        _contexto.Boletins.Add(boletim);
        _contexto.SaveChanges();
    }

    public Boletim ObterPorId(int id)
    {
        return _contexto.Boletins.Find(id);
    }

    public IList<Boletim> ObterTodos(Paginacao paginacao)
    {
        return _contexto.Boletins
            .Take(paginacao.Take)
            .Skip(paginacao.Skip)
            .ToList();
    }

    public int ObterTotal()
    {
        return _contexto.Boletins.Count();
    }
}
