using GeraEstoque.Repositories;
namespace GeraEstoque.Screens;

public static class ListarProdutosScreen
{
    public static void Iniciar(ProdutoRepository repository)
    {
        Console.Clear();

        System.Console.WriteLine("Lista de produtos Cadastrados");
        System.Console.WriteLine("=============================");
        System.Console.Write(Environment.NewLine);

        if(repository.ListaDeProdutos.Count == 0)
        {
            System.Console.WriteLine("Não há Produtos na Lista!");
        }
        else
        {

            foreach (var produto in repository.ListaDeProdutos)
            {
                System.Console.WriteLine($"Data de Cadastro: " + string.Format("{0:d}", produto.DataDeCadastro));
                System.Console.WriteLine($"Id: {produto.IdProduto}");
                System.Console.WriteLine($"Nome do Produto: {produto.NomeProduto}");
                System.Console.WriteLine($"QTD em Estoque: {produto.QuantidadeEstoque}");
                System.Console.WriteLine($"R$ Compra: {produto.ValorCompra.ToString("c")}");
                System.Console.WriteLine($"R$ Venda: {produto.ValorVenda.ToString("c")}");
                System.Console.WriteLine("=============================");
            }
            System.Console.Write(Environment.NewLine);
            System.Console.WriteLine("Pressione ENTER para voltar ao Menu Principal");
            Console.ReadLine();
        }
        
    }    
}