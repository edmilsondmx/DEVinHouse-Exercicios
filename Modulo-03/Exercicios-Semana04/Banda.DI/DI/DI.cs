using Banda.Domain.Interfaces.Repositorio;
using Banda.Domain.Interfaces.Servico;
using Banda.Domain.Services;
using Banda.Infra.DataBase;
using Banda.Infra.DataBase.Repositorios;
using Microsoft.Extensions.DependencyInjection;

namespace Banda.DI.DI;

public static class DI
{
    public static IServiceCollection Register(this IServiceCollection builder)
    {
        return builder
            .AddDbContext<BandaDBContexto>()
            .AddScoped<ITocarRepositorio, TocarRepositorio>()
            .AddScoped<ITocarServico, TocarServico>()
            .AddScoped<ITocarPost, TocarPost>();
    }
}
