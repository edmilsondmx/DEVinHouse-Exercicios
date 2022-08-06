namespace MusicApplication.Models
{
    public class Album
    {
        public int IdAlbum { get; set; }
        public Artista Artista { get; set; }
        public string Titulo { get; set; }
        public int Ano { get; set; }
        public List<Musica> ListaMusicas { get; set; }

        public Album(Artista artista, string titulo, int ano, List<Musica> listaMusicas)
        {
            Artista = artista;
            Titulo = titulo;
            Ano = ano;
            ListaMusicas = listaMusicas;
        }
    }
}
