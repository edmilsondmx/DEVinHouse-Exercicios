using Microsoft.AspNetCore.Mvc;

namespace Banda.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BandaTocarController : ControllerBase
{

    [HttpPost]
    public IActionResult Criar(

    )
    {
        return Ok()/* Created("", ) */;
    }
}
