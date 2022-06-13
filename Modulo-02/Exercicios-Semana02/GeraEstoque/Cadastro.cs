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
        Console.ReadLine();
    }
}