﻿using Microsoft.AspNetCore.Mvc;
using MusicApplication.DTOs;
using MusicApplication.Models;
using MusicApplication.Repositories;

namespace MusicApplication.Controllers
{
    [ApiController]
    [Route("api/musica")]
    public class MusicaController : ControllerBase
    {
        private readonly MusicaRepository _musicaRepository;
        private readonly ArtistaRepository _artistaRepository;
        private readonly AlbumRepository _albumRepository;
        private readonly PlaylistRepository _playlistRepository;

        public MusicaController(
            MusicaRepository musicaRepository, 
            ArtistaRepository artistaRepository,
            AlbumRepository albumRepository,
            PlaylistRepository playlistRepository)
        {
            _musicaRepository = musicaRepository;
            _artistaRepository = artistaRepository;
            _albumRepository = albumRepository;
            _playlistRepository = playlistRepository;
        }

        [HttpGet()]
        public List<Musica> Get(
            [FromQuery] string nomeMusica,
            [FromQuery] string nomeArtista,
            [FromQuery] string nomeAlbum)
        {
            if(nomeMusica != null || nomeArtista != null || nomeAlbum != null)
            {
                return _musicaRepository.ObterPorPesquisa(nomeMusica, nomeArtista, nomeAlbum);
            }

            return _musicaRepository.ObterTodasMusicas();
        }

        [HttpGet("{idMusica}")]
        public Musica GetById(
            [FromRoute] int idMusica
        )
        {
            return _musicaRepository.ObterPorId(idMusica);
        }

        [HttpPost]
        public ActionResult<Musica> Post(
            [FromBody] MusicaDto body)

        {
            var playlist = _playlistRepository.ObterPorId(body.PlaylistId);
            var artista = _artistaRepository.ObterPorId(body.ArtistaId);
            var album = _albumRepository.ObterPorId(body.AlbumId);
            var musica = new Musica(
                body.Nome, 
                body.Duracao, 
                artista
            );
            musica.Album = album;
            musica.Playlist = playlist;
            _musicaRepository.AdicionarMusica(musica);

            return Ok(musica);
        }

        [HttpPut("{idMusica}")]
        public ActionResult<Musica> Put(
            [FromBody] Musica body,
            [FromRoute] int idMusica)
        {
            var musica = _musicaRepository.ObterPorId(idMusica);

            musica.Nome = body.Nome;
            musica.Artista = body.Artista;
            musica.Duracao = body.Duracao;

            _musicaRepository.EditarMusica(musica);

            return Ok(musica);
        }

        [HttpDelete("{idMusica}")]
        public string Delete(
            [FromRoute] int idMusica)
        {
            return _musicaRepository.DeletarMusica(idMusica);
        }
    }
}
