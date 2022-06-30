namespace Empresa.Entidades;

public class FuncionarioHorista : Empregado
{
    public string? cnpj { get; set; }
    public double taxa { get; set; }
    public FuncionarioHorista()
    {
    }
    public FuncionarioHorista(int id, string? nome, string? cnpj, double taxa) : base(id, nome)
    {
        this.cnpj = cnpj;
        this.taxa = taxa;
    }

    public void CalcularTaxa()
    {
        System.Console.WriteLine("Calculando Taxa!");
    }

    public void EmitirNota()
    {
        System.Console.WriteLine("Emitindo Nota Fiscal!");
    }
}