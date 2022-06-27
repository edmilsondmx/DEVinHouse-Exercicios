using FormularioInscricao.Models;
namespace FormularioInscricao;

public static class CadastroScreen
{
    public static void Iniciar(CursoSelecionado cursos)
    {
        Console.Clear();

        System.Console.WriteLine("Área de Cadastro");
        System.Console.WriteLine("=================");
        System.Console.WriteLine();

        Console.Write("Digite o nome do aluno: ");
        string nome = Console.ReadLine()!;

        Console.Write("Digite o curso do aluno: ");
        string curso = Console.ReadLine()!;

        Console.Write("Digite a escolaridade do aluno: ");
        string escolaridade = Console.ReadLine()!;  

        Console.Write("Digite a data de nascimento do aluno: ");
        DateTime dataDeNascimento = DateTime.Parse(Console.ReadLine()!);

        Console.Write("Digite o valor do curso: ");
        decimal valorCurso = decimal.Parse(Console.ReadLine()!);

        Console.Write("Digite o valor do desconto: ");
        decimal valorDesconto = decimal.Parse(Console.ReadLine()!);  

        Console.Write("Digite o valor da multa: ");
        decimal valorMulta = decimal.Parse(Console.ReadLine()!);

        CobrarCusto custo = new CobrarCusto(valorCurso, valorMulta, valorDesconto);
        

        cursos.Cursos.Add(new FichaInscricao(nome, curso, escolaridade, dataDeNascimento, valorCurso, valorDesconto, valorMulta));

        FichaInscricao ficha01 = new FichaInscricao(nome, curso, escolaridade, dataDeNascimento, valorCurso, valorDesconto, valorMulta);

        Console.Clear();

        if(ficha01.ValorDesconto == 0)
            System.Console.WriteLine(FormatacaoTexto.Formatacao(ficha01.Nome, ficha01.Curso, ficha01.ValorCurso, custo.Resultado));
        else if(ficha01.ValorDesconto > 0 && ficha01.Idade < 18)
            System.Console.WriteLine(FormatacaoTexto.Formatacao(ficha01.Nome, ficha01.Curso, ficha01.ValorCurso, ficha01.ValorDesconto, ficha01.Idade, custo.Resultado));
        else if(ficha01.ValorDesconto > 0)
            System.Console.WriteLine(FormatacaoTexto.Formatacao(ficha01.Nome, ficha01.Curso, ficha01.ValorCurso, ficha01.ValorDesconto, custo.Resultado));

        
        Console.ReadLine();
    }
}