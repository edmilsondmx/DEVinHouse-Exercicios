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
    /// /// Implementar a regra do exercicio 8 aqui dentro do método GET
    /// </summary>
    /// <param name="valorA"></param>
    /// <param name="valorB"></param>
    /// <returns></returns>
    [HttpGet("{valorA}/{valorB}")]
    public string Get(int valorA, int valorB)
    {
        return "";
    }
}
