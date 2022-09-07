using Escola.Domain.DTO;
using Escola.Domain.Interfaces.Services;
using Escola.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Escola.Api.Controllers.V2;

[ApiController]
[Route("api/v2/materias")]
public class MateriasV2Controller : ControllerBase
{
    private readonly IMateriaServico _materiaServico;
    public MateriasV2Controller(IMateriaServico materiaServico)
    {
        _materiaServico = materiaServico;
    }

    [HttpGet]
    public IActionResult ObterTodos(
        [FromQuery] string nome,
        int skip = 0,
        int take = 10
    )
    {
        var paginacao = new Paginacao(take, skip);
        var totalRegistros = _materiaServico.ObterTotal();

        Response.Headers.Add("x-Paginacao-TotalRegistros", totalRegistros.ToString());

        if(!string.IsNullOrEmpty(nome))
            return Ok(_materiaServico
                .ObterPorNome(nome)
                .Select(m => new MateriaV2DTO(m))
            );

        return Ok(_materiaServico
            .ObterTodos(paginacao)
            .Select(m => new MateriaV2DTO(m))
        );
    }

    [HttpGet("{id}")]
    public IActionResult ObterPorId(
        [FromRoute] int id
    )
    {
        return Ok(new MateriaV2DTO(_materiaServico.ObterPorId(id)));
    }

    [HttpPost]
    public IActionResult Inserir(
        [FromBody] MateriaV2DTO materia
    )
    {
        _materiaServico.Inserir(new MateriaDTO(materia));
        return StatusCode(StatusCodes.Status201Created);
    }

    [HttpPut("{id}")]
    public IActionResult Atualizar( 
        [FromRoute]int id,
        [FromBody] MateriaV2DTO materia
    )
    {
        materia.Id = id;
        _materiaServico.Alterar(new MateriaDTO(materia), id);
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
