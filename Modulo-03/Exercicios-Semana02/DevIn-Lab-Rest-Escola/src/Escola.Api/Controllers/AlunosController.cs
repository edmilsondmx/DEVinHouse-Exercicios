using System.Diagnostics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Escola.Domain.DTO;
using Escola.Domain.Interfaces.Services;
using Escola.Domain.Exceptions;
using Escola.Domain.Models;
using Escola.Api.Config;

namespace Escola.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunosController : ControllerBase
    {
        private readonly CacheService<AlunoDTO> _alunoCache;
        private readonly IAlunoServico _alunoServico;
        public AlunosController(IAlunoServico alunoServico, CacheService<AlunoDTO> cache)
        {
            _alunoServico = alunoServico;
            _alunoCache = cache;
        }
        [HttpGet]
        public IActionResult BuscarTodos(int skip = 0, int take = 20)
        {
            var uri = $"{Request.Scheme}://{Request.Host}";
            var paginacao = new Paginacao(take, skip);
            var totalRegistros = _alunoServico.ObterTotal();

            Response.Headers.Add("x-Paginacao-TotalRegistros", totalRegistros.ToString());
            var alunos = new BaseDTO<IList<AlunoDTO>>{
                Data = _alunoServico.ObterTodos(paginacao),
                Links = GetHateoasForAll(uri, take, skip, totalRegistros)
            };
            foreach (var aluno in alunos.Data)
            {
                aluno.Links = GetHateoas(aluno, uri);
            }
            return Ok(alunos);
        }
        
        [HttpGet("{id}")]
        public IActionResult BuscarPorId(
            [FromRoute] Guid id
        )
        {
            var uri = $"{Request.Scheme}://{Request.Host}";
            AlunoDTO aluno;
            if(!_alunoCache.TryGetValue($"{id}", out aluno))
            {
                aluno = _alunoServico.ObterPorId(id);
                _alunoCache.Set($"{id}", aluno);
                aluno.Links = GetHateoas(aluno, uri);
            }
            return Ok(aluno);
            
        }

        [HttpPost]
        public IActionResult Inserir(
            [FromBody] AlunoDTO aluno)
        {
            _alunoServico.Inserir(aluno);

            return StatusCode(StatusCodes.Status201Created);
        }
        
        [HttpPut("{id}")]
        public IActionResult Alterar(
            [FromBody] AlunoDTO alunoDto,
            [FromRoute] Guid id
        )
        {
            
            alunoDto.Id = id;
            _alunoServico.Alterar(alunoDto);
            _alunoCache.Remove($"{id}");
            _alunoCache.Set($"{id}", alunoDto);
         
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Excluir(
            [FromRoute] Guid id
        )
        {
            _alunoServico.Excluir(id);
            _alunoCache.Remove($"{id}");
            return NoContent();
            
        }

        private static IList<HateoasDTO> GetHateoas(AlunoDTO aluno, string baseUrl)
        {
            var hateoas = new List<HateoasDTO>(){
                new HateoasDTO{
                    Rel = "self",
                    Type = "Get",
                    Uri = $"{baseUrl}/api/alunos/{aluno.Id}"
                },
                new HateoasDTO{
                    Rel = "aluno",
                    Type = "Get",
                    Uri = $"{baseUrl}/api/alunos/"
                },
                new HateoasDTO{
                    Rel = "aluno",
                    Type = "Put",
                    Uri = $"{baseUrl}/api/alunos/{aluno.Id}"
                },
                new HateoasDTO{
                    Rel = "aluno",
                    Type = "Delete",
                    Uri = $"{baseUrl}/api/alunos/{aluno.Id}"
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
                    Uri = $"{baseUri}/api/alunos?skip={skip}&take={take}"
                },
                new HateoasDTO(){
                    Rel = "aluno",
                    Type = "Post",
                    Uri = $"{baseUri}/api/alunos/"
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
                        Uri = $"{baseUri}/api/alunos?skip={newSkip}&take={take - razao}"
                    }
                );
            }

            if(take < ultimo)
            {
                hateoas.Add(new HateoasDTO()
                    {
                        Rel = "next",
                        Type = "Get",
                        Uri = $"{baseUri}/api/alunos?skip={skip + razao}&take={take + razao}"
                    }
                );
            }

            return hateoas;
        }
    }
}