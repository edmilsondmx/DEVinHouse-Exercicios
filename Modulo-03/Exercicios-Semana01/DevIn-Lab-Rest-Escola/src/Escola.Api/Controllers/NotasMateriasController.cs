
using Escola.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Escola.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class NotasMateriasController : ControllerBase
{
    private readonly INotasMateriaServico _notasMateriaServico;
    public NotasMateriasController(INotasMateriaServico notasMateriaServico)
    {
        _notasMateriaServico = notasMateriaServico;
    }

    [HttpGet("{id}")]
    public IActionResult ObterPorId(
        [FromRoute] int id
    )
    {
        return Ok(_notasMateriaServico.ObterPorId(id));
    }

    [HttpGet("/alunos/{idAluno}/boletims/{idBoletim}/notasmateria/")]
    public IActionResult ObterPorBoletim(
        [FromRoute] Guid idAluno,
        [FromRoute] int idBoletim
    )
    {
        return Ok(_notasMateriaServico.ObterPorBoletim((Guid)idAluno, (int)idBoletim));
    }

}
