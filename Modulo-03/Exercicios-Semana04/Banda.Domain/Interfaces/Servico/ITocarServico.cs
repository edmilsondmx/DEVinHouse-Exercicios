
using Banda.Domain.DTOs;

namespace Banda.Domain.Interfaces.Servico;

internal interface ITocarServico
{
    IList<TocarDTO> Listar();
    void Inserir(TocarDTO dto);
    void Alterar(TocarDTO dto);
    void Excluir(int id);

    
}
