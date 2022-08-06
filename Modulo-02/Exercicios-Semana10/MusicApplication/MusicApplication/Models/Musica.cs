using System.ComponentModel.DataAnnotations;

namespace MusicApplication.Models
{
    public class Musica
    {
        public int IdMusica { get; internal set; }
        [Required(ErrorMessage = "o nome da Música é obrigatório!")]
        public string Nome { get; set; }
        public TimeSpan Duracao { get; set; }
        public Artista Artista { get; set; }
        public Album Album { get; set; }

        public Musica(string nome, TimeSpan duracao, Artista artista)
        {
            Nome = nome;
            Duracao = duracao;
            Artista = artista;
        }
    }
}
