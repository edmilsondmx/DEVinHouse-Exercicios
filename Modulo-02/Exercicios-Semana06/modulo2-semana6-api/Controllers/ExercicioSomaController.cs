using Microsoft.AspNetCore.Mvc;

namespace modulo2_semana6_api.Controllers;

/// <summary>
/// Exercicio 8
/// </summary>
[ApiController]
[Route("[controller]")]
public class ExercicioSomaController : ControllerBase
{
    /// <summary>
    /// /// Implementar a regra do exercicio 8 aqui dentro do m�todo GET
    /// </summary>
    /// <param name="valorA"></param>
    /// <param name="valorB"></param>
    /// <returns></returns>
    [HttpGet("{valorA}/{valorB}")]
    public string Get(int valorA, int valorB)
    {
        try
        {
            var resultado = valorA + valorB;

            if(resultado < 10)
                return $"O resultado da soma é: {resultado}";

            var numRandomico = new Random().Next();
            return $"{numRandomico}";
            throw new Exception($"{numRandomico}");
        }
        catch (Exception ex)
        {
            
            return $"Erro: {ex}";
        }
        
        
    }
}
