
using Escola.Api.Config;
using Escola.Domain.DTO;
using Escola.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Escola.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class NotasMateriasController : ControllerBase
{
    private readonly CacheService<NotasMateriaDTO> _notasMateriaCache;
    private readonly INotasMateriaServico _notasMateriaServico;
    public NotasMateriasController(
        INotasMateriaServico notasMateriaServico, 
        CacheService<NotasMateriaDTO> notasMateriaCache)
    {
        _notasMateriaServico = notasMateriaServico;
        _notasMateriaCache = notasMateriaCache;
        notasMateriaCache.Config($"notasMateria", new TimeSpan(0,5,0));
    }

    [HttpGet("{id}")]
    public IActionResult ObterPorId(
        [FromRoute] int id
    )
    {
        var uri = $"{Request.Scheme}://{Request.Host}";
        NotasMateriaDTO notasMateria;
        if(!_notasMateriaCache.TryGetValue($"{id}", out notasMateria))
        {
            notasMateria = _notasMateriaServico.ObterPorId(id);
            _notasMateriaCache.Set($"{id}", notasMateria);
            notasMateria.Links = GetHateoas(notasMateria, uri);
        }
        return Ok(notasMateria);
    }

    [HttpGet]
    [Route("~/api/alunos/{idAluno}/boletims/{idBoletim}/notasmateria")]
    public IActionResult ObterPorBoletim(
        [FromRoute] Guid idAluno,
        [FromRoute] int idBoletim
    )
    {
        var uri = $"{Request.Scheme}://{Request.Host}";
        IList<NotasMateriaDTO> notasMaterias = _notasMateriaServico.ObterPorBoletim((Guid)idAluno, (int)idBoletim);

        foreach (var notasMateria in notasMaterias)
        {
            notasMateria.Links = GetHateoas(notasMateria, uri);
        };
        
        return Ok(notasMaterias);
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
        _notasMateriaCache.Remove($"{id}");
        _notasMateriaCache.Set($"{id}", notasMateria);
        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult Deletar(
        [FromRoute] int id
    )
    {
        _notasMateriaServico.Excluir(id);
        _notasMateriaCache.Remove($"{id}");
        return NoContent();
    }

    private static List<HateoasDTO> GetHateoas(NotasMateriaDTO notasMateria, string baseUri)
    {
        var hateoas = new List<HateoasDTO>(){
            new HateoasDTO(){
                    Rel = "self",
                    Type = "Get",
                    Uri = $"{baseUri}/api/notasmaterias/{notasMateria.Id}"
                },
                new HateoasDTO(){
                    Rel = "notasMaterias",
                    Type = "Put",
                    Uri = $"{baseUri}/api/notasmaterias/{notasMateria.Id}"
                },
                new HateoasDTO(){
                    Rel = "notasMaterias",
                    Type = "Get",
                    Uri = $"{baseUri}/api/notasmaterias/"
                },
                new HateoasDTO(){
                    Rel = "notasMaterias",
                    Type = "Delete",
                    Uri = $"{baseUri}/api/notasmaterias/{notasMateria.Id}"
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
                Uri = $"{baseUri}/api/notasmaterias?skip={skip}&take={take}"
            },
            new HateoasDTO(){
                Rel = "notasMaterias",
                Type = "Post",
                Uri = $"{baseUri}/api/notasmaterias/"
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
                    Uri = $"{baseUri}/api/notasmaterias?skip={newSkip}&take={take - razao}"
                }
            );
        }

        if(take < ultimo)
        {
            hateoas.Add(new HateoasDTO()
                {
                    Rel = "next",
                    Type = "Get",
                    Uri = $"{baseUri}/api/notasmaterias?skip={skip + razao}&take={take + razao}"
                }
            );
        }

        return hateoas;
    }


}
