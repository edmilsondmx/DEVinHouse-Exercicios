namespace MusicApplication.Models
{
    public class Artista
    {

        public int IdArtista { get; internal set; }
        public string Nome { get; set; }
        public string NomeArtistico { get; set; }
        public Artista(string nome, string nomeArtistico)
        {
            Nome = nome;
            NomeArtistico = nomeArtistico;
        }
    }
}
