namespace Rh.Domain.Exceptions;

public class NaoAutenticadoException : Exception
{
    public NaoAutenticadoException(string erro) : base (erro)
    {
        
    }
}
