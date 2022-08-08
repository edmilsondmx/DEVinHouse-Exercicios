using Microsoft.AspNetCore.Mvc;
using MusicApplication.DTOs;
using MusicApplication.Models;
using MusicApplication.Repositories;

namespace MusicApplication.Controllers
{
    [ApiController]
    [Route("api/album")]
    public class AlbumController : ControllerBase
    {

        private readonly AlbumRepository _albumRepository;
        private readonly ArtistaRepository _artistaRepository;

        public AlbumController(
            AlbumRepository albumRepository, 
            ArtistaRepository artistaRepository)
        {
            _albumRepository = albumRepository;
            _artistaRepository = artistaRepository;
        }

        [HttpGet]
        public ActionResult<Album> Get()
        {
            
            return Ok(_albumRepository.ObterTodosAlbuns());
        }

        [HttpPost]
        public ActionResult<Album> Post(
            [FromBody] AlbumDto novoAlbum)

        {
            var artista = _artistaRepository.ObterPorId(novoAlbum.ArtistaId);
            var album = new Album(
                artista,
                novoAlbum.Nome,
                novoAlbum.Ano
            ) ;

            _albumRepository.AdicionarAlbum(album);

            return Ok(album);
        }

        [HttpPut("{idAlbum}")]
        public ActionResult<Album> Put(
            [FromBody] Album body,
            [FromRoute] int idAlbum)
        {
            var album = _albumRepository.ObterPorId(idAlbum);

            album.Artista = body.Artista;
            album.Titulo = body.Titulo;
            album.Ano = body.Ano;

            _albumRepository.EditarAlbum(album);

            return Ok(album);
        }

        [HttpDelete("{idAlbum}")]
        public string Delete(
            [FromRoute] int idAlbum)
        {
            return _albumRepository.DeletarAlbum(idAlbum);
        }
    }
}
