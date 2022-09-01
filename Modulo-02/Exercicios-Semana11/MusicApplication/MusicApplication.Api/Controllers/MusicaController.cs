using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MusicApplication.Api.Data;
using MusicApplication.Api.DTOs;
using MusicApplication.Api.Models;
using MusicApplication.Api.ViewModels;

namespace MusicApplication.Api.Controllers;

[ApiController]
[Route("api/musica")]
public class MusicaController : ControllerBase
{
    private readonly MusicDbContext _context;

    public MusicaController(MusicDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public ActionResult<List<Musica>> Get(
        [FromQuery] int? idArtista,
        [FromQuery] int? idAlbum
    )
    {
        var query = _context.Musicas.AsQueryable();
        if(idArtista.HasValue)
        {
            query = query.Where(m => m.ArtistaId == idArtista);
        }
        if(idAlbum.HasValue)
        {
            query = query
                .Where(m => m.AlbumId == idAlbum)
                .Include(m => m.Artista);
        }
        return Ok(query.ToList());
    }

    [HttpGet("{idMusica}")]
    public ActionResult<Musica> GetById(
        [FromRoute] int idMusica
    )
    {
        var musicas = _context.Musicas.Include(m => m.Artista).ToList();

        return Ok(musicas.Where(m => m.Id == idMusica));
    }

    [HttpPost]
    public ActionResult<Musica> Post(
        [FromBody] MusicaDto musicaDto
    )
    {
        var artista = _context.Artistas.Find(musicaDto.ArtistaId);
        
        var album = _context.Albuns.Find(musicaDto.AlbumId);
        
        var novaMusica = new Musica(
            musicaDto.Nome,
            musicaDto.Duracao,
            artista,
            album
        );
        
        _context.Musicas.Add(novaMusica);
        _context.SaveChanges();
        return Created("api/musica", novaMusica);
    }

    [HttpPut("{idMusica}")]
    public ActionResult<Musica> Put(
        [FromRoute] int idMusica,
        [FromBody] MusicaDto musicaDto
    )
    {
        var musicaAtual = _context.Musicas.Find(idMusica);

        if(musicaAtual == null)
            return NotFound(new RetornoComFalhaViewModel("Musica não encontrada"));

        musicaAtual.Nome = musicaDto.Nome;
        musicaAtual.Duracao = musicaDto.Duracao;
        musicaAtual.ArtistaId = musicaDto.ArtistaId;

        _context.SaveChanges();
        return Ok(musicaAtual);
    }

    [HttpDelete("{idMusica}")]
    public ActionResult Delete(
        [FromRoute] int idMusica
    )
    {
        var musica = _context.Musicas.Find(idMusica);

        if(musica == null)
            return NotFound(new RetornoComFalhaViewModel("Musica não encontrada"));

        _context.Musicas.Remove(musica);
        _context.SaveChanges();

        return NoContent();
    }
}
