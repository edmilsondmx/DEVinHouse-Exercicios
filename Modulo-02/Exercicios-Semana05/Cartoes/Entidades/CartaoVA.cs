namespace Cartoes.Entidades;

class CartaoVA : Cartao
{
    public CartaoVA()
    {
    }

    public CartaoVA(string? bandeira, double saldo) : base(bandeira, saldo)
    {
    }
    public override double VerificarValorTaxaCartao()
    {
        return this.saldo * 0.03;
    }
}