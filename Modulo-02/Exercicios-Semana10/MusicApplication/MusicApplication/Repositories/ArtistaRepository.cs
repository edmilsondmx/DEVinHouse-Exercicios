using MusicApplication.Models;

namespace MusicApplication.Repositories
{
    public class ArtistaRepository
    {
        private static int _idIndice = 1;

        private static List<Artista> _artista = new();

        public List<Artista> ObterTodosArtistas()
        {
            return _artista;
        }

        public Artista ObterPorId(int id)
        {
            var artista =  _artista.FirstOrDefault(a => a.IdArtista == id);

            if (artista == null)
                return null;

            return artista;
            
        }

        public List<Artista> ObterPorNome(string nome)
        {
            var artista = _artista.Where(a => a.Nome == nome || a.Nome.Contains(nome)).ToList();

            return artista;
        }

        public Artista CriarArtista(Artista artista)
        {
            artista.IdArtista = _idIndice;
            _idIndice++;

            _artista.Add(artista);

            return artista;
        }

        public Artista AtualizarArtista(Artista artista)
        {
            var artistaAtual = ObterPorId(artista.IdArtista);

            artistaAtual.Nome = artista.Nome;
            artistaAtual.NomeArtistico = artista.NomeArtistico;

            return artistaAtual;
        }



        public string DeletarArtista(int idArtista)
        {
            var artista = ObterPorId(idArtista);

            _artista.Remove(artista);

            return $"Artista: {artista.Nome}, removido com sucesso!";
        }
    }
}
