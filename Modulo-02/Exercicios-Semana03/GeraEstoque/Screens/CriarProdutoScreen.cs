using GeraEstoque.Models;
using GeraEstoque.Repositories;
namespace GeraEstoque.Screens;

public static class CriarProdutoScreen
{
    public static void Iniciar(ProdutoRepository repository)
    {
        Console.Clear();
        MenuScreen.Bordas();

        Console.SetCursorPosition(2, 1);
        System.Console.WriteLine("Área de Cadastro");
        Console.SetCursorPosition(2, 2);
        System.Console.WriteLine("=================");

        DateTime DataDeCadastro = DateTime.Now;

        Console.SetCursorPosition(2, 4);
        Console.Write("Nome do Produto: ");
        string nomeProduto = Console.ReadLine();

        Console.SetCursorPosition(2, 5);
        Console.Write("Quantidade em estoque: ");
        ushort quantidadeEstoque = ushort.Parse(Console.ReadLine());

        Console.SetCursorPosition(2, 6);
        Console.Write("Valor de Compra: ");
        decimal valorCompra = decimal.Parse(Console.ReadLine());

        Console.SetCursorPosition(2, 7);
        Console.Write("Valor de Venda: ");
        decimal valorVenda = decimal.Parse(Console.ReadLine());

        repository.ListaDeProdutos.Add(new Produto(nomeProduto, quantidadeEstoque,valorCompra, valorVenda));
        
        ShowProduto(repository, DataDeCadastro, nomeProduto, quantidadeEstoque, valorCompra, valorVenda);
    }

    public static void ShowProduto(ProdutoRepository repository, DateTime data, string? nome, ushort qtd, decimal vCompra, decimal vVenda)
        {
            Console.Clear();
            MenuScreen.Bordas();

            Console.SetCursorPosition(2, 1);
            System.Console.WriteLine("Produto Cadastrado com Sucesso!");
            Console.SetCursorPosition(2, 2);
            System.Console.WriteLine("-------------------------------");

            Console.SetCursorPosition(2, 4);
            System.Console.WriteLine($"Nome: Produto {nome}");
            Console.SetCursorPosition(2, 5);
            System.Console.WriteLine($"Qtd: {qtd}");
            Console.SetCursorPosition(2, 6);
            System.Console.WriteLine($"R$ Compra:{vCompra.ToString("c")}");
            Console.SetCursorPosition(2, 7);
            System.Console.WriteLine($"R$ Venda:{vVenda.ToString("c")}");
            Console.SetCursorPosition(2, 8);
            System.Console.WriteLine($"Data de Cadastro: "+ string.Format("{0:d}", data));

            Console.SetCursorPosition(2, 10);
            System.Console.WriteLine("Pressione qualquer tecla");
            Console.SetCursorPosition(2, 11);
            System.Console.Write("para voltar ao menu principal!");

            if(Console.ReadKey().Key != ConsoleKey.F1) {
                
                MenuScreen.Iniciar(repository);
            }


        }
}