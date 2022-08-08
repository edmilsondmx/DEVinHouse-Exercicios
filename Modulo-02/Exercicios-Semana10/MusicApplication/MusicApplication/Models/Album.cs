using System.ComponentModel.DataAnnotations;

namespace MusicApplication.Models
{
    public class Album
    {
        public int IdAlbum { get; internal set; }
        public Artista Artista { get; set; }
        [Required(ErrorMessage = "O nome do Album é obrigatório!")]
        public string Titulo { get; set; }
        [Range(1500, 3000, ErrorMessage = "Ano Fora do intervalo necesário!")]
        public int Ano { get; set; }

        public Album(Artista artista, string titulo, int ano)
        {
            Artista = artista;
            Titulo = titulo;
            Ano = ano;
        }
    }
}
