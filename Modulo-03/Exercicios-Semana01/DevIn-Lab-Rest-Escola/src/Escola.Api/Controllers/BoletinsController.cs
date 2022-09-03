using Escola.Domain.DTO;
using Escola.Domain.Interfaces.Services;
using Escola.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Escola.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BoletinsController : ControllerBase
{
    private readonly IBoletimServico _boletimServico;

    public BoletinsController(IBoletimServico boletimServico)
    {
        _boletimServico = boletimServico;
    }

    /* [HttpGet]
    public IActionResult ObterTodos(
        int take = 0, int skip = 20)
    {
        var paginacao = new Paginacao(take, skip);
        var totalRegistros = _boletimServico.ObterTotal();

        Response.Headers.Add("x-Paginacao-TotalRegistros", totalRegistros.ToString());
        return Ok(_boletimServico.ObterTodos(paginacao).ToList());
    } */
    [HttpGet]
    public IActionResult ObterPorNome(
        string nome,
        int take = 0, 
        int skip = 20
    )
    {
        var paginacao = new Paginacao(take, skip);
        var totalRegistros = _boletimServico.ObterTotal();

        Response.Headers.Add("x-Paginacao-TotalRegistros", totalRegistros.ToString());
        if(!string.IsNullOrEmpty(nome))
        {
            return Ok(_boletimServico.ObterPorNome(nome, paginacao));
        }
        return Ok(_boletimServico.ObterTodos(paginacao));
    }

    [HttpGet("aluno/{idaluno}/boletins")]
    public IActionResult ObterPoId(
        [FromRoute] Guid idaluno,
        int take = 0, 
        int skip = 20
    )
    {
        var paginacao =  new Paginacao(take, skip);
        var totalRegistros = _boletimServico.ObterTotal();

        Response.Headers.Add("x-Paginacao-TotalRegistros", totalRegistros.ToString());
        return Ok(_boletimServico.ObterPorIdAluno(idaluno, paginacao));
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
    
    

}
