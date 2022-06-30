namespace Cartoes.Entidades;

public class Cartao
{
    public string? bandeira { get; set; }
    public double saldo { get; set; }
    public double valorTaxa { get; set; }
    public Cartao()
    {
    }
    public Cartao(string? bandeira, double saldo, double valorTaxa)
    {
        this.bandeira = bandeira;
        this.saldo = saldo;
        this.valorTaxa = valorTaxa;
    }

    public double VerificarValorTaxaCartao()
    {
        var taxa = valorTaxa / 100;
        return saldo * taxa; 
    }


    
}