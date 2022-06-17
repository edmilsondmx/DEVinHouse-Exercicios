namespace GeraEstoque.Models;

public class Produto
{
    public string IdProduto;
    public string NomeProduto;
    public ushort QuantidadeEstoque;
    public decimal ValorCompra;
    public decimal ValorVenda;

    public Produto(string nome, ushort qtdEstoque, decimal custo, decimal venda)
    {
        IdProduto = Guid.NewGuid().ToString().Substring(0, 8);
        NomeProduto = nome;
        QuantidadeEstoque = qtdEstoque;
        ValorCompra = custo;
        ValorVenda = venda;
    }
}