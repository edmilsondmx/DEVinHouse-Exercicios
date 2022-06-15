namespace GeraEstoque.Screens;

public static class MenuScreen
{
    public static void Iniciar()
    {
        
        Console.Clear();
        Bordas();
        Opcoes();

        var opcoes = short.Parse(Console.ReadLine());
        switch (opcoes)
        {
            case 1: Cadastro.Start(); break;
            case 2: break;
            case 3: break;
            case 4: break;
            case 0: Console.Clear(); break;
            default: break;
        }
        

    }
    static void Bordas()
    {

        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Green;

        LinhaHoriziontal();
        for (int i = 0; i < 14; i++)
        {
        Console.Write("|");
        for (int line = 0; line <= 35; line++)
            Console.Write(" ");
            
        Console.Write("|");
        Console.Write(Environment.NewLine);
        }
        LinhaHoriziontal(); 
    }
    static void LinhaHoriziontal()
    {
        Console.Write("+");
        for (int i = 0; i <= 35; i++)
            Console.Write("-");

        Console.Write("+");
        Console.Write(Environment.NewLine);
    }

    static void Opcoes()
    {
        Console.SetCursorPosition(2, 1);
        System.Console.WriteLine("Seja bem vindo ao GeraEstoque v1.0");
        Console.SetCursorPosition(2, 2);
        System.Console.WriteLine("==================================");

        Console.SetCursorPosition(2, 4);
        System.Console.WriteLine("1 - Cadastrar Produto");

        Console.SetCursorPosition(2, 5);
        System.Console.WriteLine("2 - Consultar Produto");

        Console.SetCursorPosition(2, 6);
        System.Console.WriteLine("3 - Modificar Produto");

        Console.SetCursorPosition(2, 7);
        System.Console.WriteLine("4 - Excluir Produto");

        Console.SetCursorPosition(2, 8);
        System.Console.WriteLine("0 - Sair");

        Console.SetCursorPosition(2, 10);
        System.Console.Write("Digite a opção: ");
    }
    

    public static class Cadastro
    {
        public static void Start()
        {
            Console.Clear();
            MenuScreen.Bordas();

            Console.SetCursorPosition(2, 1);
            System.Console.WriteLine("Área de Cadastro");
            Console.SetCursorPosition(2, 2);
            System.Console.WriteLine("=================");

            CadastrarProduto();
        }

        public static void CadastrarProduto()
        {
            var idProduto = Guid.NewGuid().ToString().Substring(0, 8);

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

            ShowProduto(idProduto, nomeProduto, quantidadeEstoque, valorCompra, valorVenda);
        }

        public static void ShowProduto(string id, string? nome, ushort qtd, decimal vCompra, decimal vVenda)
        {
            Console.Clear();
            MenuScreen.Bordas();

            Console.SetCursorPosition(2, 1);
            System.Console.WriteLine("Produto Cadastrado com Sucesso!");
            Console.SetCursorPosition(2, 2);
            System.Console.WriteLine("-------------------------------");

            Console.SetCursorPosition(2, 4);
            System.Console.WriteLine($"ID: {id}");
            Console.SetCursorPosition(2, 5);
            System.Console.WriteLine($"Nome: Produto {nome}");
            Console.SetCursorPosition(2, 6);
            System.Console.WriteLine($"Qtd: {qtd}");
            Console.SetCursorPosition(2, 7);
            System.Console.WriteLine($"R$ Compra:{vCompra.ToString("c")}");
            Console.SetCursorPosition(2, 8);
            System.Console.WriteLine($"R$ Venda:{vVenda.ToString("c")}");

            Console.SetCursorPosition(2, 10);
            System.Console.WriteLine("Pressione qualquer tecla");
            Console.SetCursorPosition(2, 11);
            System.Console.Write("para voltar ao menu principal!");
            
            if(Console.ReadKey().Key != ConsoleKey.F1)
            {
                MenuScreen.Iniciar();
            }



        }
    }
}