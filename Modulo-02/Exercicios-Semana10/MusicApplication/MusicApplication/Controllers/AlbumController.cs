using Microsoft.AspNetCore.Mvc;
using MusicApplication.Models;
using MusicApplication.Repositories;

namespace MusicApplication.Controllers
{
    [ApiController]
    [Route("api/album")]
    public class AlbumController : Controller
    {

        private readonly AlbumRepository _albumRepository;

        public AlbumController(AlbumRepository albumRepository)
        {
            _albumRepository = albumRepository;
        }

        [HttpGet]
        public List<Album> Get()
        {
            
            return _albumRepository.ObterTodosAlbuns();
        }

        [HttpPost]
        public ActionResult<Album> Post(
            [FromBody] Album novoAlbum)

        {

            var album = new Album(
                novoAlbum.Artista,
                novoAlbum.Titulo,
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
