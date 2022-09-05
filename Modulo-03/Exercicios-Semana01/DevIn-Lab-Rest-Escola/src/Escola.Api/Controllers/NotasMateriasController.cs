
using Escola.Domain.DTO;
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

    [HttpPost]
    public IActionResult Inserir(
        [FromBody] NotasMateriaDTO notasMateria
    )
    {
        _notasMateriaServico.Inserir(notasMateria);
        return StatusCode(StatusCodes.Status201Created);
    }
    [HttpPut("{id}")]
    public IActionResult Atualizar(
        [FromRoute] int id,
        [FromBody] NotasMateriaDTO notasMateria
    )
    {
        notasMateria.Id = id;
        _notasMateriaServico.Alterar(notasMateria);
        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult Deletar(
        [FromRoute] int id
    )
    {
        _notasMateriaServico.Excluir(id);
        return NoContent();
    }


}
