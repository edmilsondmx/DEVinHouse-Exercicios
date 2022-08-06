using MusicApplication.Models;

namespace MusicApplication.Repositories
{
    public class MusicaRepository
    {
        private static int _idIndice = 1;

        private static List<Musica> _musica = new();

        public Musica AdicionarMusica(Musica musica)
        {
            musica.IdMusica = _idIndice;
            _idIndice++;

            _musica.Add(musica);

            return musica;

        }

        public List<Musica> ObterTodasMusicas()
        {
            return _musica;
        }

        public Musica ObterPorId(int id)
        {
            var musica = _musica.FirstOrDefault(a => a.IdMusica == id);

            if (musica == null)
                return null;

            return musica;

        }

        public Musica EditarMusica(Musica musica)
        {
            var musicaAtual = ObterPorId(musica.IdMusica);

            musicaAtual.Nome = musica.Nome;
            musicaAtual.Duracao = musica.Duracao;
            musicaAtual.Artista = musica.Artista;
            musicaAtual.Album = musica.Album;

            return musicaAtual;
        }

        public string DeletarMusica(int idMusica)
        {
            var musica = ObterPorId(idMusica);

            _musica.Remove(musica);

            return $"Musica: {musica.Nome} | {musica.Artista}, removido com sucesso!";
        }

        public List<Musica> ObterPorAlbum(int idAlbum)
        {
            return _musica
                .Where(musica => musica.Album != null)
                .Where(musica => musica.Album.IdAlbum == idAlbum)
                .ToList();
        }
    }
}
