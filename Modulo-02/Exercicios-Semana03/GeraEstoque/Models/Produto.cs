namespace GeraEstoque.Models;

public class Produto
{
    public DateTime DataDeCadastro;
    
    public string? IdProduto;
    public string? NomeProduto;
    public ushort QuantidadeEstoque;
    public decimal ValorCompra;
    public decimal ValorVenda;

    public Produto()
    {
        
    }
    public Produto(string nome, ushort qtdEstoque, decimal custo, decimal venda)
    {
        
        DataDeCadastro = DateTime.Now;
        IdProduto = Guid.NewGuid().ToString().Substring(0, 8);
        NomeProduto = nome;
        QuantidadeEstoque = qtdEstoque;
        ValorCompra = custo;
        ValorVenda = venda;
    }
    
    public override string ToString()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        
        return $"Produto: Data: {DataDeCadastro.ToString("d")} | Id: {IdProduto} |  Nome: {NomeProduto} | Qtd: {QuantidadeEstoque} | R$ Compra: {ValorCompra.ToString("c")} | R$ Venda: {ValorVenda.ToString("c")}";
    }
}