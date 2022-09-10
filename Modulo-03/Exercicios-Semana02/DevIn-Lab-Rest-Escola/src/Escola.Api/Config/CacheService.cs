using Microsoft.Extensions.Caching.Memory;

namespace Escola.Api.Config;

public class CacheService<TEntity>
{
    private readonly IMemoryCache _cache;
    private string _baseKey;
    private TimeSpan _expiracao;
    public CacheService(IMemoryCache cache)
    {
        _cache = cache;
    }

    public void Config(string basekey, TimeSpan expiracao)
    {
        _baseKey = basekey;
        _expiracao = expiracao;
    }

    public TEntity Set(string paramento, TEntity entity)
    {
        return _cache.Set<TEntity>(MontarString(paramento), entity, _expiracao);
    }

    public bool TryGetValue(string paramento, out TEntity entity)
    {
        return _cache.TryGetValue<TEntity>(MontarString(paramento), out entity);
    }

    public void Remove(string paramento)
    {
        _cache.Remove(MontarString(paramento));
    }


    public string MontarString(string parametro)
    {
        return $"{_baseKey}: {parametro}";
    }
}
