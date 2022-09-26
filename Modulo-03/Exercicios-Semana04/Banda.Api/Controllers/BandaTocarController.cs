using Banda.Domain.DTOs;
using Banda.Domain.Interfaces.Servico;
using Banda.Domain.Services;
using Microsoft.AspNetCore.Mvc;


namespace Banda.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BandaTocarController : ControllerBase
{
    private readonly ITocarServico _tocarServico;
    private readonly ITocarPost _tocarPost;

    public BandaTocarController(ITocarServico tocarServico, ITocarPost tocarPost)
    {
        _tocarServico = tocarServico;
        _tocarPost = tocarPost;
    }

    [HttpGet]
    [Route("listar")]
    public IActionResult Listar()
    {
        return Ok(_tocarServico.Listar());
    }

    [HttpPost]
    [Route("inserir")]
    public IActionResult Criar(
        [FromBody] TocarDTO dto
    )
    {
        _tocarPost.Inserir(dto);

        return Created("api/tocar", dto);
    }

    [HttpPut("{id}")]
    public IActionResult Alterar(
        [FromRoute] int id,
        [FromBody] TocarDTO dto
    )
    {
        dto.Id = id;
        _tocarServico.Alterar(dto);
        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult Deletar(
        [FromRoute] int id
    )
    {
        _tocarServico.Excluir(id);
        return NoContent();
    }

    [HttpGet]
    [Route("GetCommand")]
    public string GetCommand()
    {
        TestesCommand testes = new TestesCommand();

        ICommand bandaInterage = new BandaCommand("Banda Interage com o público!");
        ICommand testeSom = new TecnicoSomCommand(testes);
        ICommand testeLuz = new TecnicoLuzCommand(testes);

        Invoker invoker = new Invoker(bandaInterage, testeSom, testeLuz);

        return invoker.ExecutarRotinaDoCommand();
    }
}
