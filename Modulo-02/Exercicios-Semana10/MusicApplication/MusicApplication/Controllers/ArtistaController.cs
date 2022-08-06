using Microsoft.AspNetCore.Mvc;
using MusicApplication.Models;
using MusicApplication.Repositories;

namespace MusicApplication.Controllers
{
    [ApiController]
    [Route("api/artista")]
    public class ArtistaController : ControllerBase
    {
        

        private readonly ArtistaRepository _artistaRepository;
        

        public ArtistaController(ArtistaRepository artistaRepository)
        {
            _artistaRepository = artistaRepository;
        }

        [HttpGet]
        public List<Artista> Get(
            [FromQuery] string? nome)
        {
            if(!String.IsNullOrEmpty(nome))
            {
                return _artistaRepository.ObterPorNome(nome);
            }
            return _artistaRepository.ObterTodosArtistas();
        }

        [HttpPost]
        public ActionResult<Artista> Post(
            [FromBody] Artista novoArtista)
            
        {

            var artista = new Artista(
                novoArtista.Nome,
                novoArtista.NomeArtistico,
                novoArtista.PaisOrigem
            );

            _artistaRepository.CriarArtista(artista);

            return Ok(artista);
        }

        [HttpPut("{idArtista}")]
        public ActionResult<Artista> Put(
            [FromBody] Artista body,
            [FromRoute] int idArtista)
        {
            var artista = _artistaRepository.ObterPorId(idArtista);

            artista.Nome = body.Nome;
            artista.NomeArtistico = body.NomeArtistico;
            artista.PaisOrigem = body.PaisOrigem;

            _artistaRepository.AtualizarArtista(artista);

            return Ok(artista);
        }

        [HttpDelete("{idArtista}")]
        public string Delete(
            [FromRoute] int idArtista)
        {
            return _artistaRepository.DeletarArtista(idArtista);
        }
    }
}