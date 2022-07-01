namespace Cartoes.Entidades;

class CartaoVR : Cartao
{
    public CartaoVR()
    {
    }

    public CartaoVR(string? bandeira, double saldo) : base(bandeira, saldo)
    {
        
    }
    public override double VerificarValorTaxaCartao()
    {
        return this.saldo * 0.02;
    }
}