
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
    public IActionResult ObterTodos(
        [FromQuery] string nome
    )
    {
        if(!string.IsNullOrEmpty(nome))
            return Ok(_materiaServico.ObterPorNome(nome));

        return Ok(_materiaServico.ObterTodos());
    }

    [HttpGet("{id}")]
    public IActionResult ObterPorId(
        [FromRoute] int id
    )
    {
        return Ok(_materiaServico.ObterPorId(id));
    }
}
