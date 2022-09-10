using Escola.Api.Config;
using Escola.Domain.DTO;
using Escola.Domain.Interfaces.Services;
using Escola.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Escola.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BoletinsController : ControllerBase
{
    private readonly CacheService<BoletimDTO> _boletimCache;
    private readonly IBoletimServico _boletimServico;

    public BoletinsController(IBoletimServico boletimServico, CacheService<BoletimDTO> cache)
    {
        _boletimServico = boletimServico;
        _boletimCache = cache;
        cache.Config("boletim", new TimeSpan(0,5,0));

    }

    [HttpGet]
    public IActionResult ObterPorNome(
        string nome,
        int take = 0, 
        int skip = 10
    )
    {
        var uri = $"{Request.Scheme}://{Request.Host}";
        var paginacao = new Paginacao(take, skip);
        var totalRegistros = _boletimServico.ObterTotal();

        Response.Headers.Add("x-Paginacao-TotalRegistros", totalRegistros.ToString());
        if(!string.IsNullOrEmpty(nome))
        {
            var boletins = new BaseDTO<IList<BoletimDTO>>(){
                Data = _boletimServico.ObterPorNome(nome, paginacao),
                Links = GetHateoasForAll(uri, take, skip, totalRegistros)
            };
        
            foreach (var boletim in boletins.Data)
            {
                boletim.Links = GetHateoas(boletim, uri);
            }
            return Ok(boletins);
        }
        return Ok(_boletimServico.ObterTodos(paginacao));
    }

    [HttpGet]
    [Route("~/api/alunos/{idaluno}/boletins")]
    public IActionResult ObterPoId(
        [FromRoute] Guid idaluno,
        int take = 0, 
        int skip = 20
    )
    {
        var uri = $"{Request.Scheme}://{Request.Host}";
        var paginacao =  new Paginacao(take, skip);
        var totalRegistros = _boletimServico.ObterTotal();

        Response.Headers.Add("x-Paginacao-TotalRegistros", totalRegistros.ToString());

        var boletins = new BaseDTO<IList<BoletimDTO>>(){
            Data = _boletimServico.ObterPorIdAluno(idaluno, paginacao),
            Links = GetHateoasForAll(uri, take, skip, totalRegistros)
        };
        foreach (var boletim in boletins.Data)
        {
            boletim.Links = GetHateoas(boletim, uri);
        }

        return Ok(boletins);
    }

    [HttpPost]
    public IActionResult Inserir(
        [FromBody] BoletimDTO boletim
    )
    {
        _boletimServico.Inserir(boletim);
        return StatusCode(StatusCodes.Status201Created);
    }

    [HttpPut("{id}")]
    public IActionResult Alterar(
        [FromRoute] int id,
        [FromBody] BoletimDTO boletim
    )
    {
        _boletimServico.Alterar(boletim, id);
        return Ok();
    }

    [HttpDelete("{boletimId}/materia")]
    public IActionResult Excluir(
        [FromRoute] int boletimId,
        int materiaId
    )
    {
        _boletimServico.ExcluirMateria(boletimId, materiaId);
        return NoContent();
    }
    
    private static IList<HateoasDTO> GetHateoas(BoletimDTO boletim, string baseUrl)
        {
            var hateoas = new List<HateoasDTO>(){
                new HateoasDTO{
                    Rel = "self",
                    Type = "Get",
                    Uri = $"{baseUrl}/api/boletins/{boletim.Id}"
                },
                new HateoasDTO{
                    Rel = "boletim",
                    Type = "Get",
                    Uri = $"{baseUrl}/api/alunos/{boletim.AlunoId}/boletins/"
                },
                new HateoasDTO{
                    Rel = "boletim",
                    Type = "Put",
                    Uri = $"{baseUrl}/api/boletins/{boletim.Id}"
                },
                new HateoasDTO{
                    Rel = "boletim",
                    Type = "Delete",
                    Uri = $"{baseUrl}/api/boletins/{boletim.Id}"
                },
            };
            return hateoas;
        }

        private List<HateoasDTO> GetHateoasForAll( string baseUri, int take, int skip, int ultimo)
        {
            var hateoas =   new List<HateoasDTO>(){
                new HateoasDTO(){
                    Rel = "self",
                    Type = "Get",
                    Uri = $"{baseUri}/api/boletins?skip={skip}&take={take}"
                },
                new HateoasDTO(){
                    Rel = "boletim",
                    Type = "Post",
                    Uri = $"{baseUri}/api/boletins/"
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
                        Uri = $"{baseUri}/api/boletins?skip={newSkip}&take={take - razao}"
                    }
                );
            }

            if(take < ultimo)
            {
                hateoas.Add(new HateoasDTO()
                    {
                        Rel = "next",
                        Type = "Get",
                        Uri = $"{baseUri}/api/boletins?skip={skip + razao}&take={take + razao}"
                    }
                );
            }

            return hateoas;
        }

}
