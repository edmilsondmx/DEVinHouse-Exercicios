namespace MusicApplication.Models
{
    public class Musica
    {
        public int IdMusica { get; set; }
        public string Nome { get; set; }
        public TimeSpan Duracao { get; set; }
        public Artista Artista { get; set; }
        public Album Album { get; set; }


    }
}
