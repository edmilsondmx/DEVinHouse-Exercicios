using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Extensions;
using Rh.Api.DTOs;
using Rh.Api.Enuns;
using Rh.Api.Interfaces.Service;
using Rh.Api.Models;
using Rh.Api.Services;
using Rh.Domain.DTOs;

namespace Rh.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FuncionarioController : ControllerBase
{
    private readonly IFuncionarioService _funcionarioService;
    public FuncionarioController(IFuncionarioService funcionarioService)
    {
        _funcionarioService = funcionarioService;
    }

    [Authorize]
    [HttpGet("listar")]
    public IActionResult Listar(
    )
    {
        if(User.IsInRole(Permissoes.Funcionario.GetDisplayName()))
        {
            return Ok(_funcionarioService.ObterTodos().Select(f => new {f.Nome, f.Permissao}));
        }
        
        return Ok(_funcionarioService.ObterTodos());
    }

    [HttpPost("cadastrar-funcionario")]
    public IActionResult Cadastrar(
        [FromBody] FuncionarioDTO funcionario
    )
    {
        _funcionarioService.CadastrarFuncionario(funcionario);
        return StatusCode(StatusCodes.Status201Created);
    }

    [HttpDelete("excluir-funcionario/{id}")]
    public IActionResult ExcluirFuncionario(
        [FromRoute] string id
    )
    {
        var funcionario  = _funcionarioService.ObterPorId(id);
        _funcionarioService.Remover(funcionario);
        return NoContent();
    }

    [HttpDelete("excluir-gerente/{id}")]
    public IActionResult ExcluirGerente(
        [FromRoute] string id
    )
    {
        var funcionario  = _funcionarioService.ObterPorId(id);
        _funcionarioService.Remover(funcionario);
        return NoContent();
    }

    [HttpPut("alterar-salario/{id}")]
    public IActionResult AlterarSalario(
        [FromRoute] string id,
        [FromBody] SalarioDTO salario
    )
    {
        var funcionario = _funcionarioService.ObterPorId(id);
        funcionario.Salario = salario.Salario;
        _funcionarioService.Editar(funcionario);
        return Ok();
    }
}
