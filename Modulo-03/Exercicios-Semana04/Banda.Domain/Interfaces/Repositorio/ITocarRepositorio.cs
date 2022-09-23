using Banda.Domain.Models;

namespace Banda.Domain.Interfaces.Repositorio;

internal interface ITocarRepositorio
{
    IList<Tocar> Listar();
    void Inserir(Tocar tocar);
    void Alterar(Tocar tocar);
    void Excluir(int id);
}
