using Microsoft.AspNetCore.Mvc;

namespace modulo2_semana6_api.Controllers;

[ApiController]
[Route("[controller]")]
public class ExemploTestController : ControllerBase
{

    [HttpGet("{valor}")]
    public string Get(int valor)
    {
        if (valor > 10)
        {
            return "O Retorno do Valor é maior que dez";
        }

        return "O Retorno do Valor é menor que dez";
    }
}
