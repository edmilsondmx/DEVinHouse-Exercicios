using FormularioInscricao.Models;
namespace FormularioInscricao;

static class Program
{
    static void Main(string[] args)
    {
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

        FichaInscricao ficha01 = new FichaInscricao(nome, curso, escolaridade, dataDeNascimento, valorCurso, valorDesconto, valorMulta);

        if(ficha01.ValorDesconto == 0)
            System.Console.WriteLine(FormatacaoTexto.Formatacao(ficha01.Nome, ficha01.Curso, ficha01.ValorCurso));
        else if(ficha01.ValorDesconto > 0 && ficha01.Idade < 18)
            System.Console.WriteLine(FormatacaoTexto.Formatacao(ficha01.Nome, ficha01.Curso, ficha01.ValorCurso, ficha01.ValorDesconto, ficha01.Idade));
        else if(ficha01.ValorDesconto > 0)
            System.Console.WriteLine(FormatacaoTexto.Formatacao(ficha01.Nome, ficha01.Curso, ficha01.ValorCurso, ficha01.ValorDesconto));

        
        Console.ReadLine();

        
    }
}