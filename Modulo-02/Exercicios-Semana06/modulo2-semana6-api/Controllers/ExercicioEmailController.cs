using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc;

namespace modulo2_semana6_api.Controllers;

/// <summary>
/// Exercicio 4
/// </summary>
[ApiController]
[Route("[controller]")]
public class ExercicioEmailController : ControllerBase
{
    /// <summary>
    /// Implementar a regra do exercicio 4 aqui dentro do GET
    /// </summary>
    /// <param name="email"></param>
    /// <returns></returns>
    [HttpGet("{email}")]
    public string Get(string email)
    {
        try
        {
            ValidarEmail(email);
            return "E-mail válido!";
        }
        catch (Exception ex)
        {
            
            return $"Erro: {ex}";
        }
        
        
    }

    private static void ValidarEmail(string email)
    {
        Regex regexEmail = new Regex("[A-Za-z0-9\\._-]+@[A-Za-z0-9]+\\..(\\.[A-Za-z]+)*");
        if(!regexEmail.IsMatch(email))
            throw new EmailInvalidoException(email);

    }
}

[Serializable]
public class EmailInvalidoException : Exception
{
    public EmailInvalidoException()
    {
    }
    public EmailInvalidoException(string email)
    : base(String.Format($"Email invalido: {email}"))
    {

    }
    
}
