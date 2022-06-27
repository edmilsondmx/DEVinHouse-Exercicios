namespace FormularioInscricao;

public static class MenuScreen
{
    public static void Iniciar(CursoSelecionado cursos)
    {
        Console.Clear();
        Opcoes();

        var opcoes = short.Parse(Console.ReadLine()!);
        switch (opcoes)
        {
            case 1: CadastroScreen.Iniciar(cursos); Iniciar(cursos); break;
            case 2: ListarCursos.Iniciar(cursos); Iniciar(cursos); break;
            case 0: Console.Clear(); Environment.Exit(0); break;
            default: break;
        }
        

    }

    static void Opcoes()
    {
        System.Console.WriteLine("Seja bem vindo ao Formulário de Cursos");
        System.Console.WriteLine("======================================");

        System.Console.WriteLine("1 - Preencher Formulário");

        System.Console.WriteLine("2 - Listar Cursos");

        System.Console.WriteLine("0 - Sair");

        System.Console.Write("Digite a opção: ");
    }
}