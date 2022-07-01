namespace Cartoes.Entidades;

class CartaoVT : Cartao
{
    public CartaoVT()
    {
    }

    public CartaoVT(string? bandeira, double saldo) : base(bandeira, saldo)
    {
    }
    public override double VerificarValorTaxaCartao()
    {
        return this.saldo * 0.025;
    }
}