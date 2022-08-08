using System.ComponentModel.DataAnnotations;

namespace MusicApplication.Models
{
    public class Artista
    {

        public int IdArtista { get; internal set; }
        [Required(ErrorMessage = "O nome do artista é obrigatório!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O nome artistico é obrigatório!")]
        public string NomeArtistico { get; set; }
        public string PaisOrigem { get; set; }
        public Artista(string nome, string nomeArtistico, string paisOrigem)
        {
            Nome = nome;
            NomeArtistico = nomeArtistico;
            PaisOrigem = paisOrigem;
        }
    }
}
