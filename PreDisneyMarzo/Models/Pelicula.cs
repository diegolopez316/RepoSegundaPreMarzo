using System.ComponentModel.DataAnnotations;

namespace PreDisneyMarzo.Models
{
    public class Pelicula
    {
        public int Id { get; set; }

        public string Imagen { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaDeCreacion { get; set; }
        public int Calificacion { get; set; }
        [Range (1, 5)]
        public ICollection<Personaje> PersonajeList { get; set; } = new List<Personaje> ();
    }
}
