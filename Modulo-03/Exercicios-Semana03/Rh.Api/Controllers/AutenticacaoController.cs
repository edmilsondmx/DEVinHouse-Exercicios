using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
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
            return StatusCode(StatusCodes.Status403Forbidden);

        var token = TokenService.GenerateToken(funcionario);
        var refreshToken = TokenService.GenerateRefreshToken();
        TokenService.SaveRefreshToken(funcionario.Nome, refreshToken);
        
        return Ok( new {
            token,
            refreshToken
        });
    }

    [HttpPost]
    [Route("refresh-token")]
    [AllowAnonymous]
    public IActionResult Refresh(
        [FromQuery] string token,
        [FromQuery] string refreshToken
    )
    {
        var principal = TokenService.GetPrincipalFromExpiredToken(token);
        var username = principal.Identity.Name;
        var savedRefreshToken = TokenService.GetRefreshToken(username);

        if(savedRefreshToken != refreshToken)
            throw new SecurityTokenException("Invalid Token");

        var newToken = TokenService.GenerateToken(principal.Claims);
        var newRefreshToken = TokenService.GenerateRefreshToken();
        TokenService.DeleteRefreshToken(username, refreshToken);
        TokenService.SaveRefreshToken(username, newRefreshToken);

        return Ok(new {
            newToken,
            newRefreshToken
        });

    }
}
