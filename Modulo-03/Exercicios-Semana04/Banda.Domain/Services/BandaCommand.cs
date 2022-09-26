

using Banda.Domain.Interfaces.Servico;

namespace Banda.Domain.Services;

public class BandaCommand : ICommand
{
    private string _interacao = String.Empty;

    public BandaCommand(string interacao)
    {
        _interacao = interacao;
    }

    public string Execute()
    {
        return _interacao;
    }
}
