namespace Banda.Infra.DataBase.Repositorios;

public class BaseRepositorio <TEntity, Tkey> where TEntity : class
{
    private readonly BandaDBContexto _contexto;

    public BaseRepositorio(BandaDBContexto contexto)
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

    public virtual IList<TEntity> Listar()
    {
        return _contexto.Set<TEntity>().ToList();
    }
}
