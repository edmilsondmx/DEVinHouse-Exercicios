namespace MusicApplication.Models
{
    public class Album
    {
        public int IdAlbum { get; set; }
        public string Titulo { get; set; }
        public int Ano { get; set; }
        public List<Musica> ListaMusicas { get; set; }
    }
}
