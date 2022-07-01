using Exercicio05.Entidades;
namespace Exercicio05;


internal class Program
{
    static void Main(string[] args)
    {
        
        Funcionario objetoFuncionario = null;//new Funcionario("Edmilson Gomes", "256482");
        

        try
        {

            ValidarNomeFuncionario(objetoFuncionario);

            System.Console.WriteLine($"Nome: {objetoFuncionario.Nome} | Id: {objetoFuncionario.Id}");

        }
        catch (Exception ex)
        {
            System.Console.WriteLine(ex.Message);

        }
        

        
        
    }

    private static void ValidarNomeFuncionario(Funcionario objetoFuncionario)
    {
        if(objetoFuncionario == null)
            throw new NullReferenceException("O objeto Funcionário é Null!");

    }
}