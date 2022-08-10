using System.ComponentModel.DataAnnotations;

namespace MusicApplication.Models
{
    public class Playlist
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Nome da Playlist obrigatório.")]
        public string Nome { get; set; }
        public string Estilo { get; set; }
        public List<Musica> Musicas { get; set; } = new ();

        public Playlist(string nome, string estilo)
        {
            Nome = nome;
            Estilo = estilo;

        }

        public void AdicionarMusicas(Musica musica)
        {
            Musicas ??= new List<Musica> ();

            Musicas.Add(musica);
        }

        public void RemoverMusicas(int idMusica)
        {
            var musicaAtual = Musicas.FirstOrDefault(m => m.IdMusica == idMusica);
            Musicas.Remove(musicaAtual);
        }
    }
}
