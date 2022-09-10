using Escola.Domain.Interfaces.Repositories;
using Escola.Domain.Models;

namespace Escola.Infra.DataBase.Repositories;

public class BoletimRepositorio : BaseRepositorio<Boletim, int>, IBoletimRepositorio
{
    public BoletimRepositorio(EscolaDBContexto contexto) : base(contexto)
    {
    }
    public void ExcluirMateria(Boletim boletim, NotasMateria materia)
    {
        boletim.Notas.Remove(materia);
        _contexto.SaveChanges();
    }
}
