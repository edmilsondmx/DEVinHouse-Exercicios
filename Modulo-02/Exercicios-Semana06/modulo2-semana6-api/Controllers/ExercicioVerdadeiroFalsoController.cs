using Microsoft.AspNetCore.Mvc;

namespace modulo2_semana6_api.Controllers;

/// <summary>
/// Exercicio 1
/// </summary>
[ApiController]
[Route("[controller]")]
public class ExercicioVerdadeiroFalsoController : ControllerBase
{
    /// <summary>
    /// Implementar a regra do exercicio 1 aqui dentro do m�todo GET
    /// </summary>
    /// <param name="tipo"></param>
    /// <returns></returns>
    [HttpGet("{tipo}")]
    public string Get(string tipo)
    {
        if(tipo == "verdadeiro" && tipo == "falso")
            return $"O texto foi {tipo}";
        
        throw new Exception("Texto diferente de verdadeiro ou falso");
    }
}
