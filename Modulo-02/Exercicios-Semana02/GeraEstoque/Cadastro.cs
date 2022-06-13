namespace GeraEstoque;

public static class Cadastro
{
    public static void Start()
    {
        Console.Clear();
        Menu.Bordas();

        Console.SetCursorPosition(2, 1);
        System.Console.WriteLine("Área de Cadastro");
        Console.SetCursorPosition(2, 2);
        System.Console.WriteLine("=================");

        CadastrarProduto();
    }

    public static void CadastrarProduto()
    {
        Console.SetCursorPosition(2, 4);
        Console.Write("Nome do Produto: ");
        string nomeProduto = Console.ReadLine();

        Console.SetCursorPosition(2, 5);
        Console.Write("Quantidade em estoque: ");
        ushort quantidadeEstoque = ushort.Parse(Console.ReadLine());

        Console.SetCursorPosition(2, 6);
        Console.Write("Valor de Compra: ");
        float valorCompra = float.Parse(Console.ReadLine());

        Console.SetCursorPosition(2, 7);
        Console.Write("Valor de Venda: ");
        float valorVenda = float.Parse(Console.ReadLine());
    }
}