namespace Rh.Domain.Exceptions;

public class NaoAutorizadoException : Exception
{
    public NaoAutorizadoException(string erro) : base(erro)
    {
        
    }
}
