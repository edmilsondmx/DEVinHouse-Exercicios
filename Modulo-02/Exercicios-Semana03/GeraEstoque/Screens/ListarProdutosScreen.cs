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
            System.Console.Write(Environment.NewLine);
            System.Console.WriteLine("Pressione ENTER para voltar ao Menu Principal");
            Console.ReadLine();
        }
        else
        {

            foreach (var produto in repository.ListaDeProdutos)
            {
                System.Console.WriteLine(produto.ToString());

                Console.ForegroundColor = ConsoleColor.Green;

                System.Console.WriteLine("=======================================================================================================================");
            }
            System.Console.Write(Environment.NewLine);
            System.Console.WriteLine("Pressione ENTER para voltar ao Menu Principal");
            Console.ReadLine();
        }
        
    }    
}