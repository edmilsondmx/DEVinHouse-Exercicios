using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MusicApplication.Api.Data;
using MusicApplication.Api.DTOs;
using MusicApplication.Api.Models;
using MusicApplication.Api.ViewModels;

namespace MusicApplication.Api.Controllers;

[ApiController]
[Route("api/artista")]
public class ArtistaController : ControllerBase
{
    private readonly MusicDbContext _context;

    public ArtistaController(MusicDbContext context)
    {
        _context = context;
    }

    
    [HttpGet]
    public ActionResult<List<Artista>> Get()
    {
        return Ok(_context.Artistas.ToList());
    }

    [HttpGet("{id}")]
    public ActionResult<Artista> GetById(
        [FromRoute] int idArtista
    )
    {
        return Ok(_context.Artistas.Find(idArtista));
    }

    [HttpPost]
    public ActionResult<Artista> Post(
        [FromBody] ArtistaDto artista
    )
    {   
        var novoArtista = _context.Artistas.FirstOrDefault(a => a.Nome == artista.Nome);
        if(novoArtista != null)
        {
            return BadRequest(new RetornoComFalhaViewModel("Artista já cadastrado!"));
        }

        novoArtista = new Artista(
            artista.Nome,
            artista.NomeArtistico,
            artista.PaisOrigem
        );

        _context.Artistas.Add(novoArtista);
        _context.SaveChanges();
        return Created("api/artista", novoArtista);
    }

    [HttpPut("{idArtista}")]
    public ActionResult<Artista> Put(
        [FromRoute] int idArtista,
        [FromBody] ArtistaDto artistaDto
    )
    {
        var artistaAtual = _context.Artistas.Find(idArtista);

        artistaAtual.Nome = artistaDto.Nome;
        artistaAtual.NomeArtistico = artistaDto.NomeArtistico;
        artistaAtual.PaisOrigem = artistaDto.PaisOrigem;

        _context.SaveChanges();
        return Ok(artistaAtual);
    }

    [HttpDelete("{idArtista}")]
    public ActionResult Delete(
        [FromRoute] int idArtista
    )
    {
        var artistaAtual = _context.Artistas.Find(idArtista);

        if(artistaAtual == null)
            return NotFound();

        _context.Artistas.Remove(artistaAtual);
        _context.SaveChanges();

        return NoContent();
    }

}
