using Escola.Domain.Models;

namespace Escola.Infra.DataBase.Repositories;

public class BaseRepositorio<TEntity, Tkey> where TEntity : class
{
    protected readonly EscolaDBContexto _contexto;
    public BaseRepositorio(EscolaDBContexto contexto)
    {
        _contexto = contexto;
    }

    public virtual void Alterar(TEntity entity)
    {
        _contexto.Set<TEntity>().Update(entity);
        _contexto.SaveChanges();
    }

    public virtual void Excluir(TEntity entity)
    {
        _contexto.Set<TEntity>().Remove(entity);
        _contexto.SaveChanges();
    }
    
    public virtual void Inserir(TEntity entity)
    {
        _contexto.Set<TEntity>().Add(entity);
        _contexto.SaveChanges();
    }

    public virtual TEntity ObterPorId(Tkey key)
    {
        return _contexto.Set<TEntity>().Find(key);
    }

    public virtual IList<TEntity> ObterTodos(Paginacao paginacao)
    {
        return _contexto.Set<TEntity>()
                .Take(paginacao.Take)
                .Skip(paginacao.Skip)
                .ToList();
    }

    public virtual int ObterTotal()
    {
        return _contexto.Set<TEntity>().Count();
    }
}
