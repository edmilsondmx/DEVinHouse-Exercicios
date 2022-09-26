
using Banda.Domain.DTOs;

namespace Banda.Domain.Interfaces.Servico;

internal interface ITocarServico
{
    IList<TocarDTO> Listar();
    void Alterar(TocarDTO dto);
    void Excluir(int id);
}
