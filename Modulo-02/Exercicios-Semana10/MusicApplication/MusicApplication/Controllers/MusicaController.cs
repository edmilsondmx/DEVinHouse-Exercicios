using Microsoft.AspNetCore.Mvc;
using MusicApplication.Models;
using MusicApplication.Repositories;

namespace MusicApplication.Controllers
{
    [ApiController]
    [Route("api/musica")]
    public class MusicaController : Controller
    {
        private readonly MusicaRepository _musicaRepository;

        public MusicaController(MusicaRepository musicaRepository)
        {
            _musicaRepository = musicaRepository;
        }

        [HttpGet]
        public List<Musica> Get()
        {

            return _musicaRepository.ObterTodasMusicas();
        }

        [HttpPost]
        public ActionResult<Musica> Post(
            [FromBody] Musica novaMusica)

        {

            var musica = new Musica(
                novaMusica.Nome, 
                novaMusica.Duracao, 
                novaMusica.Artista);

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
