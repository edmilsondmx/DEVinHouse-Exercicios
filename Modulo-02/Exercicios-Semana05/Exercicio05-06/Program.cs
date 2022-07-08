using System.Text.RegularExpressions;
using Exercicio05.Entidades;
namespace Exercicio05;


internal class Program
{
    static void Main(string[] args)
    {
        
        Funcionario objetoFuncionario = new Funcionario("Edmilson", "256a482");
        

        try
        {

            ValidarObjeto(objetoFuncionario);
            ValidarNomeFuncionario(objetoFuncionario);
            ValidarIdFuncionario(objetoFuncionario);

            System.Console.WriteLine($"Nome: {objetoFuncionario.Nome} | Id: {objetoFuncionario.Id}");

        }
        catch (Exception ex)
        {
            System.Console.WriteLine(ex.Message);

        }
        
    }

    private static void ValidarObjeto(Funcionario objetoFuncionario)
    {
        if(objetoFuncionario == null)
            throw new NullReferenceException("O objeto Funcionário é Null!");

    }

    private static void ValidarNomeFuncionario(Funcionario objetoFuncionario)
    {
        Regex regexName = new Regex("^[a-zA-Z]+$");
        if(!regexName.IsMatch(objetoFuncionario.Nome))
            throw new NomeFuncionarioInvalidoException(objetoFuncionario.Nome);

    }
    private static void ValidarIdFuncionario(Funcionario objetoFuncionario)
    {
        Regex regexId = new Regex("^[0-9]+$");
        if(!regexId.IsMatch(objetoFuncionario.Id))
            throw new IdFuncionarioInvalidoException(objetoFuncionario.Id);


    }


}