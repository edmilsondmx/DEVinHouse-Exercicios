using Microsoft.AspNetCore.Mvc;
using Rh.Api.DTOs;
using Rh.Api.Interfaces.Service;
using Rh.Api.Repositories;
using Rh.Api.Services;
using Rh.Domain.DTOs;

namespace Rh.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AutenticacaoController : ControllerBase
{

    private readonly IFuncionarioService _funcionarioService;
    public AutenticacaoController(IFuncionarioService funcionarioService)
    {
        _funcionarioService = funcionarioService;
    }

    [HttpPost]
    [Route("login")]
    public IActionResult Login(
        [FromBody] FuncionarioLoginDto dto
    )
    {
        var funcionario = _funcionarioService.ObterPorUsuario(dto);
        if(funcionario == null)
            return StatusCode(StatusCodes.Status401Unauthorized);

        var token = TokenService.GenerateToken(funcionario);
        
        return Ok(token);
    }
}
