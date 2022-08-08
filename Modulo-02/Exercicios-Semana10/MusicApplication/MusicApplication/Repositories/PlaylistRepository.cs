using MusicApplication.Models;

namespace MusicApplication.Repositories
{
    public class PlaylistRepository
    {
        private static int _idIndice = 1;

        private static List<Playlist> _playlist = new();

        public Playlist AdicionarPlaylist(Playlist playlist)
        {
            playlist.Id = _idIndice;
            _idIndice++;

            _playlist.Add(playlist);

            return playlist;

        }

        public List<Playlist> ObterTodasPlaylist()
        {
            return _playlist;
        }

        public Playlist ObterPorId(int id)
        {
            var playlist = _playlist.FirstOrDefault(p => p.Id == id);

            if (playlist == null)
                return null;

            return playlist;

        }

        public Playlist EditarPlaylist(Playlist playlist)
        {
            var playlistAtual = ObterPorId(playlist.Id);

            playlistAtual.Nome = playlist.Nome;

            return playlistAtual;
        }

        public string DeletarPlaylist(int id)
        {
            var playlist = ObterPorId(id);

            _playlist.Remove(playlist);

            return $"Playlist: {playlist.Nome}, removida com sucesso!";
        }

        public Playlist AdicionarMusicaNaPlaylist(Playlist playlist, Musica musica)
        {
            var playlistAtual = ObterPorId(playlist.Id);

            playlistAtual.AdicionarMusicas(musica);

            return playlistAtual;

        }
    }
}
