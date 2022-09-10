
using Escola.Api.Config;
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
    private readonly CacheService<MateriaDTO> _materiaCache;
    private readonly IMateriaServico _materiaServico;
    public MateriasController(
        IMateriaServico materiaServico,
        CacheService<MateriaDTO> materiaCache)
    {
        _materiaServico = materiaServico;
        _materiaCache = materiaCache;
        materiaCache.Config("materia", new TimeSpan(0,5,0));
    }

    [HttpGet]
    public IActionResult ObterTodos(
        [FromQuery] string nome,
        int skip = 0,
        int take = 10
    )
    {
        var uri = $"{Request.Scheme}://{Request.Host}";
        var paginacao = new Paginacao(take, skip);
        var totalRegistros = _materiaServico.ObterTotal();

        Response.Headers.Add("x-Paginacao-TotalRegistros", totalRegistros.ToString());

        BaseDTO<IList<MateriaDTO>> materiasPorNome;

        if(!string.IsNullOrEmpty(nome))
        {   
            materiasPorNome = new BaseDTO<IList<MateriaDTO>>()
            {
                Data = _materiaServico.ObterPorNome(nome).ToList(),
                Links = GetHateoasForAll(uri, take, skip,totalRegistros)
            };
            
            foreach (var materia in materiasPorNome.Data)
            {
                materia.Links = GetHateoas(materia, uri);
            }
            return Ok(materiasPorNome);
        }

        var materias = new BaseDTO<IList<MateriaDTO>>(){
            Data = _materiaServico.ObterTodos(paginacao).ToList(),
            Links = GetHateoasForAll(uri, take, skip, totalRegistros)
        };
        foreach (var materia in materias.Data)
        {
            materia.Links = GetHateoas(materia, uri);
        }
            
        return Ok(materias);
    }

    [HttpGet("{id}")]
    public IActionResult ObterPorId(
        [FromRoute] int id
    )
    {
        var uri = $"{Request.Scheme}://{Request.Host}";
        MateriaDTO materia;
        if(!_materiaCache.TryGetValue($"{id}", out materia))
        {
            materia = _materiaServico.ObterPorId(id);
            _materiaCache.Set($"{id}", materia);
            materia.Links =  GetHateoas(materia, uri);
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
        _materiaCache.Remove($"{id}");
        _materiaCache.Set($"{id}", materia);

        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult Excluir(
        [FromRoute] int id
    )
    {
        _materiaServico.Excluir(id);
        _materiaCache.Remove($"{id}");
        return NoContent();
    }


    private static List<HateoasDTO> GetHateoas(MateriaDTO materia, string baseUri)
    {
        var hateoas = new List<HateoasDTO>(){
            new HateoasDTO(){
                    Rel = "self",
                    Type = "Get",
                    Uri = $"{baseUri}/api/materias/{materia.Id}"
                },
                new HateoasDTO(){
                    Rel = "materia",
                    Type = "Put",
                    Uri = $"{baseUri}/api/materias/{materia.Id}"
                },
                new HateoasDTO(){
                    Rel = "materia",
                    Type = "Get",
                    Uri = $"{baseUri}/api/materias/"
                },
                new HateoasDTO(){
                    Rel = "materia",
                    Type = "Delete",
                    Uri = $"{baseUri}/api/materias/{materia.Id}"
                }
        };
        return hateoas;
    }
    private List<HateoasDTO> GetHateoasForAll( string baseUri, int take, int skip, int ultimo)
    {
        var hateoas =   new List<HateoasDTO>(){
            new HateoasDTO(){
                Rel = "self",
                Type = "Get",
                Uri = $"{baseUri}/api/materias?skip={skip}&take={take}"
            },
            new HateoasDTO(){
                Rel = "materia",
                Type = "Post",
                Uri = $"{baseUri}/api/materias/"
            }
        };
        var razao = take - skip;
        if(skip != 0)
        {
            var newSkip = skip - razao;
            if(newSkip < 0)
            {
                newSkip = 0;
            }
            hateoas.Add(new HateoasDTO()
                {
                    Rel = "prev",
                    Type = "Get",
                    Uri = $"{baseUri}/api/materias?skip={newSkip}&take={take - razao}"
                }
            );
        }

        if(take < ultimo)
        {
            hateoas.Add(new HateoasDTO()
                {
                    Rel = "next",
                    Type = "Get",
                    Uri = $"{baseUri}/api/materias?skip={skip + razao}&take={take + razao}"
                }
            );
        }

        return hateoas;
    }
    
}
