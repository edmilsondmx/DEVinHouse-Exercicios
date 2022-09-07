
using Escola.Domain.DTO;
using Escola.Domain.Interfaces.Services;
using Escola.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace Escola.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MateriasController : ControllerBase
{
    private readonly IMateriaServico _materiaServico;
    private readonly IMemoryCache _cache;
    public MateriasController(IMateriaServico materiaServico, IMemoryCache cache)
    {
        _materiaServico = materiaServico;
        _cache = cache;
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

        IList<MateriaDTO> materia;
        if(!string.IsNullOrEmpty(nome))
        {
            if(!_cache.TryGetValue($"materia {nome}", out materia))
            {
                materia = _materiaServico.ObterPorNome(nome);
                _cache.Set($"materia {nome}", materia, new TimeSpan(0,5,0));
            }
            return Ok(materia);
        }
            
        return Ok(_materiaServico.ObterTodos(paginacao));
    }

    [HttpGet("{id}")]
    public IActionResult ObterPorId(
        [FromRoute] int id
    )
    {
        MateriaDTO materia;
        if(!_cache.TryGetValue($"materia {id}", out materia))
        {
            materia = _materiaServico.ObterPorId(id);
            _cache.Set($"materia {id}", materia, new TimeSpan(0,5,0));
        }

        return Ok(materia);
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
        _cache.Remove($"materia {id}");
        _cache.Set($"materia {id}", materia, new TimeSpan(0,5,0));
        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult Excluir(
        [FromRoute] int id
    )
    {
        _materiaServico.Excluir(id);
        _cache.Remove($"materia {id}");
        return NoContent();
    }
}
