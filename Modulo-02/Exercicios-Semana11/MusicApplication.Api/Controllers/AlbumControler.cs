using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MusicApplication.Api.Data;
using MusicApplication.Api.DTOs;
using MusicApplication.Api.Models;

namespace MusicApplication.Api.Controllers;


[ApiController]
[Route("api/album")]
public class AlbumControler : ControllerBase
{
    private readonly MusicDbContext _context;

    public AlbumControler(MusicDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public ActionResult<List<Album>> Get()
    {
        return Ok(_context.Albuns.ToList());
    }

    [HttpGet("{idAlbum}")]
    public ActionResult<Album> GetById(
        [FromRoute] int idAlbum
    )
    {
        var albuns = _context.Albuns.Include(a => a.Artista).ToList();

        return Ok(albuns.Where(a => a.Id == idAlbum));
    }

    [HttpPost]
    public ActionResult<Album> Post(
        [FromBody] AlbumDto albumDto
    )
    {
        var artista = _context.Artistas.Find(albumDto.ArtistaId);
        var novoAlbum = new Album(
            albumDto.Nome,
            albumDto.AnoLancamento,
            artista
        );

        _context.Albuns.Add(novoAlbum);
        _context.SaveChanges();
        return Created("api/album", novoAlbum);
    }

    [HttpPut("{idAlbum}")]
    public ActionResult<Album> Put(
        [FromRoute] int idAlbum,
        [FromBody] AlbumDto albumDto
    )
    {
        var albumAtual = _context.Albuns.Find(idAlbum);

        albumAtual.Nome = albumDto.Nome;
        albumAtual.Ano = albumDto.AnoLancamento;
        albumAtual.ArtistaId = albumDto.ArtistaId;

        _context.SaveChanges();
        return Ok(albumAtual);
    }

    [HttpDelete("{idAlbum}")]
    public ActionResult Delete(
        [FromRoute] int idAlbum
    )
    {
        var albumAtual = _context.Albuns.Find(idAlbum);

        if(albumAtual == null)
            return NotFound();

        _context.Albuns.Remove(albumAtual);
        _context.SaveChanges();

        return NoContent();
    }
}
