namespace Cartoes.Entidades;

class CartaoVT : Cartao
{
    public CartaoVT()
    {
    }

    public CartaoVT(string? bandeira, double saldo, double valorTaxa) : base(bandeira, saldo, valorTaxa)
    {
    }
}