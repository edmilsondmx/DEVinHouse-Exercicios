using Microsoft.AspNetCore.Mvc;
using MusicApplication.DTOs;
using MusicApplication.Models;
using MusicApplication.Repositories;

namespace MusicApplication.Controllers
{
    [ApiController]
    [Route("api/playlist")]
    public class PlaylistController : ControllerBase
    {
        private readonly PlaylistRepository _playlistRepository;
        private readonly MusicaRepository _musicaRepository;

        public PlaylistController(
            PlaylistRepository playlistRepository, 
            MusicaRepository musicaRepository)
        {
            _playlistRepository = playlistRepository;
            _musicaRepository = musicaRepository;
        }

        [HttpGet]
        public ActionResult<Playlist> Get()
        {
            return Ok(_playlistRepository.ObterTodasPlaylist());
        }

        [HttpPost]
        public ActionResult<Playlist> Post(
            [FromBody] PlaylistDto novaLista)
        {
            var playlist = new Playlist(
                novaLista.Nome,
                novaLista.Estilo);

            _playlistRepository.AdicionarPlaylist(playlist);

            return Ok(playlist);
        }

        [HttpPost("AddMusicas")]
        public ActionResult<Playlist> PostAddMusica(
            [FromBody] AddNaPlaylistDto body)
        {
            var playlist = _playlistRepository.ObterPorId(body.IdPlaylist);
            var musica = _musicaRepository.ObterPorId(body.MusicaId);

            _playlistRepository.AdicionarMusicaNaPlaylist(playlist, musica);

            return Ok(playlist);
        }

        [HttpPut("{idPlaylist}")]
        public Playlist Put(
            [FromBody] PlaylistDto body,
            [FromRoute] int idPlaylist
        )
        {
            var playlist = _playlistRepository.ObterPorId(idPlaylist);

            playlist.Nome = body.Nome;
            playlist.Estilo = body.Estilo;

            _playlistRepository.EditarPlaylist(playlist);
            return playlist;
        }

        [HttpDelete("{idPlaylist}")]
        public string Delete(
            [FromRoute] int idPlaylist
        )
        {
            return _playlistRepository.DeletarPlaylist(idPlaylist);
        }

        [HttpDelete("{idPlaylist}/{idMusica}")]
        public Playlist DeleteMusica(
            [FromRoute] int idPlaylist,
            [FromRoute] int idMusica
        )
        {
            var playlist = _playlistRepository.ObterPorId(idPlaylist);
            return _playlistRepository.RemoverMusicaDaPlaylist(playlist, idMusica);
        }




    }
}
