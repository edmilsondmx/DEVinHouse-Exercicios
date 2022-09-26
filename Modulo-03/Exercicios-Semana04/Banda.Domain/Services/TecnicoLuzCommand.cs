using Banda.Domain.Interfaces.Servico;

namespace Banda.Domain.Services;

public class TecnicoLuzCommand : ICommand
{
    private readonly TestesCommand _teste;

    public TecnicoLuzCommand(TestesCommand teste)
    {
        _teste = teste;
    }

    public string Execute()
    {
        string retornoIniciar = _teste.Iniciar();
        string retornoFinalizar = _teste.Finalizar();

        return $"TecnicoLuzCommand - {retornoIniciar} - {retornoFinalizar}";

    }
}
