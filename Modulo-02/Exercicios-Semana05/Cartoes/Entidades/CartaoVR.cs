namespace Cartoes.Entidades;

class CartaoVR : Cartao
{
    public CartaoVR()
    {
    }

    public CartaoVR(string? bandeira, double saldo, double valorTaxa) : base(bandeira, saldo, valorTaxa)
    {
        
    }
}