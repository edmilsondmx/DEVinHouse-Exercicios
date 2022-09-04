
using Escola.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Escola.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MateriasController : ControllerBase
{
    private readonly IMateriaServico _materiaServico;
    public MateriasController(IMateriaServico materiaServico)
    {
        _materiaServico = materiaServico;
    }

    [HttpGet]
    public IActionResult ObterTodos()
    {
        return Ok(_materiaServico.ObterTodos());
    }
}
