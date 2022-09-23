
using Banda.Domain.Interfaces.Repositorio;
using Banda.Domain.Models;

namespace Banda.Infra.DataBase.Repositorios;

public class TocarRepositorio : BaseRepositorio<Tocar, int>,  ITocarRepositorio
{
    public TocarRepositorio(BandaDBContexto contexto) : base (contexto)
    {
        
    }   
}
