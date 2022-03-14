namespace PreDisneyMarzo.Models
{
    public class Genero
    {
        public int Id { get; set; }

        public string Imagen { get; set; }
        public string Nombre { get; set; }
        
        public ICollection <Pelicula> PeliculaList { get; set; } =  new List<Pelicula>();

    }
}
