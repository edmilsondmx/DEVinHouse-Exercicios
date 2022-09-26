using Banda.Domain.Interfaces.Servico;

namespace Banda.Domain.Services;

internal class Invoker
{
    private readonly ICommand bandaCommand;
    private readonly ICommand tecnicoSomCommand;
    private readonly ICommand tecnicoLuzCommand;

    public Invoker(ICommand bandaCommand, ICommand tecnicoSomCommand, ICommand tecnicoLuzCommand)
    {
        this.bandaCommand = bandaCommand;
        this.tecnicoSomCommand = tecnicoSomCommand;
        this.tecnicoLuzCommand = tecnicoLuzCommand;
    }

    public string ExecutarRotinaDoCommand()
    {
        string retornoBanda = bandaCommand.Execute();
        string retornoTecnicoSom = tecnicoSomCommand.Execute();
        string retornoTecnicoLuz = tecnicoLuzCommand.Execute();

        return @$"{retornoBanda}
{retornoTecnicoSom}
{retornoTecnicoLuz}";
    }
}
