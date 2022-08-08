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
            var musica = _musicaRepository.ObterPorId(novaLista.MusicaId);
            var playlist = new Playlist(
                novaLista.Nome,
                musica);

            _playlistRepository.AdicionarPlaylist(playlist);

            return Ok(playlist);
        }
    }
}
