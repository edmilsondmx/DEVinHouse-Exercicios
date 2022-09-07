namespace Escola.Domain.Exceptions;

public class ExisteRegistroException : Exception
{
    public ExisteRegistroException(string erro) : base(erro)
    {
        
    }
}
