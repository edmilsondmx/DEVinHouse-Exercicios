namespace MusicApplication.Models
{
    public class Album
    {
        public int IdAlbum { get; internal set; }
        public Artista Artista { get; set; }
        public string Titulo { get; set; }
        public int Ano { get; set; }
        //public List<Musica> ListaMusicas { get; set; }

        public Album(Artista artista, string titulo, int ano)
        {
            Artista = artista;
            Titulo = titulo;
            Ano = ano;
            //ListaMusicas = listaMusicas;
        }
    }
}
