namespace PreDisneyMarzo.Models
{
    public class Personaje
    {
        public int Id { get; set; }

        public string Imagen { get; set; }
        public string Nombre { get; set; }

        public int Edad { get; set; }

        public int Peso { get; set; }

        public string Historia { get; set; }

        public  ICollection<Pelicula> PeliculaList { get; set; } = new List<Pelicula>();
    }
}
