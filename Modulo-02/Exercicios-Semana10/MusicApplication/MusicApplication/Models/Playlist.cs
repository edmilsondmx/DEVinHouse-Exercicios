using System.ComponentModel.DataAnnotations;

namespace MusicApplication.Models
{
    public class Playlist
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Nome da Playlist obrigatório.")]
        public string Nome { get; set; }
        public List<Musica> Musicas { get; set; }        
    }
}
