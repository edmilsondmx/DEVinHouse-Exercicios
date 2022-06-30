namespace Empresa.Entidades;

public class Secretaria : SalarioEmpregado
{
    public int qtdAnosEmpresa { get; set; }
    public Secretaria()
    {
    }

    public Secretaria(int id, string? nome, int codigoFuncionario, double valorSalario, int qtdAnosEmpresa) : base(id, nome, codigoFuncionario, valorSalario)
    {
        this.qtdAnosEmpresa = qtdAnosEmpresa;
    }

    public void AtenderCliente()
    {
        System.Console.WriteLine("Atendendo Cliente!");
    }
    public void RealizarLigacao()
    {
        System.Console.WriteLine("Realizandfo ligação!");
    }
}