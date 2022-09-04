
using Escola.Domain.DTO;
using Escola.Domain.Interfaces.Services;
using Escola.Domain.Models;
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

    [HttpPost]
    public IActionResult Inserir(
        [FromBody] MateriaDTO materia
    )
    {
        _materiaServico.Inserir(materia);
        return StatusCode(StatusCodes.Status201Created);
    }

    [HttpPut("{id}")]
    public IActionResult Atualizar( 
        [FromRoute]int id,
        [FromBody] MateriaDTO materia
    )
    {
        materia.Id = id;
        _materiaServico.Alterar(materia, id);
        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult Excluir(
        [FromRoute] int id
    )
    {
        _materiaServico.Excluir(id);
        return NoContent();
    }
}
