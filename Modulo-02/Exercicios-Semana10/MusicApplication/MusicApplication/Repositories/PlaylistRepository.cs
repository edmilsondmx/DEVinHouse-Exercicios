using MusicApplication.Models;

namespace MusicApplication.Repositories
{
    public class PlaylistRepository
    {
        private static int _idIndice = 1;

        private static List<Playlist> _playlist = new();

        public Playlist AdicionarPlaylist(Playlist playlist)
        {
            album.IdAlbum = _idIndice;
            _idIndice++;

            _album.Add(album);

            return album;

        }

        public List<Album> ObterTodosAlbuns()
        {
            return _album;
        }

        public Album ObterPorId(int id)
        {
            var album = _album.FirstOrDefault(a => a.IdAlbum == id);

            if (album == null)
                return null;

            return album;

        }

        public Album EditarAlbum(Album album)
        {
            var albumAtual = ObterPorId(album.IdAlbum);

            albumAtual.Titulo = album.Titulo;
            albumAtual.Ano = album.Ano;
            albumAtual.Artista = album.Artista;

            return albumAtual;
        }

        public string DeletarAlbum(int idAlbum)
        {
            var album = ObterPorId(idAlbum);

            _album.Remove(album);

            return $"Album: {album.Titulo} | {album.Artista.NomeArtistico}, removido com sucesso!";
        }
    }
}
