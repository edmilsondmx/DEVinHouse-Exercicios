using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MusicApplication.Api.Data;
using MusicApplication.Api.DTOs;
using MusicApplication.Api.Models;

namespace MusicApplication.Api.Controllers;

[ApiController]
[Route("api/playlist")]
public class PlaylistController : ControllerBase
{
    private readonly MusicDbContext _context;

    public PlaylistController(MusicDbContext context)
    {
        _context = context;
    }

    [HttpGet]
        public ActionResult<Playlist> Get()
        {
            return Ok(_context.Playlists.Include(p => p.Musicas));
        }

        [HttpPost]
        public ActionResult<Playlist> Post(
            [FromBody] PlaylistDto novaLista)
        {
            var playlist = new Playlist(
                novaLista.Nome,
                novaLista.Estilo
            );

            _context.Playlists.Add(playlist);
            _context.SaveChanges();

            return Ok(playlist);
        }

        [HttpPost("AddMusicas")]
        public ActionResult<Playlist> PostAddMusica(
            [FromBody] AddNaPlaylistDto body)
        {
            var playlist = _context.Playlists.Find(body.IdPlaylist);
            var musica = _context.Musicas.Find(body.MusicaId);
            if(musica == null || playlist == null)
                return NotFound();

            playlist.Musicas.Add(musica);

            _context.SaveChanges();

            return Ok(playlist);
        }

        [HttpPut("{idPlaylist}")]
        public Playlist Put(
            [FromBody] PlaylistDto body,
            [FromRoute] int idPlaylist
        )
        {
            var playlist = _context.Playlists.Find(idPlaylist);

            playlist.Nome = body.Nome;
            playlist.Estilo = body.Estilo;

            _context.SaveChanges();
            return playlist;
        }

        [HttpDelete("{idPlaylist}")]
        public ActionResult Delete(
            [FromRoute] int idPlaylist
        )
        {
            var playlist = _context.Playlists.Find(idPlaylist);
            if(playlist == null) return NotFound();

            _context.Playlists.Remove(playlist);
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{idPlaylist}/{idMusica}")]
        public ActionResult DeleteMusica(
            [FromRoute] int idPlaylist,
            [FromRoute] int idMusica
        )
        {
            var playlist = _context.Playlists.Find(idPlaylist);
            var musica = _context.Musicas.Find(idMusica);

            playlist.Musicas.Remove(musica);
            _context.SaveChanges();

            return NoContent();
        }
}
