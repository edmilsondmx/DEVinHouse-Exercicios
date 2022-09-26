using Banda.Domain.Interfaces.Servico;

namespace Banda.Domain.Services;

public class TecnicoSomCommand : ICommand
{
    private readonly TestesCommand _teste;

    public TecnicoSomCommand(TestesCommand teste)
    {
        _teste = teste;
    }

    public string Execute()
    {
        string retornoIniciar = _teste.Iniciar();
        string retornoFinalizar = _teste.Finalizar();

        return $"TecnicoSomCommand - {retornoIniciar} - {retornoFinalizar}";

    }
}
