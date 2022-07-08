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
        if(ValidarEmail(email))
            return "E-mail válido!";
        return "E-mail inválido!";
        throw new EmailInvalidoException(email);
        
    }

    private static bool ValidarEmail(string email)
    {
        var regexEmail = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";

        var valido = Regex.IsMatch(email,regexEmail);
        if(valido)
            return true;
        
        return false;
        
    }
}

[Serializable]
public class EmailInvalidoException : Exception
{
    public EmailInvalidoException()
    {
    }
    public EmailInvalidoException(string email)
    : base(String.Format($"E-mail inválido: {email}"))
    {

    }
    
}
