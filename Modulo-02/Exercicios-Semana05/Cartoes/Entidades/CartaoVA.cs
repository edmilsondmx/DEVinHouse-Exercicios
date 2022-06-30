namespace Cartoes.Entidades;

class CartaoVA : Cartao
{
    public CartaoVA()
    {
    }

    public CartaoVA(string? bandeira, double saldo, double valorTaxa) : base(bandeira, saldo, valorTaxa)
    {
    }
}