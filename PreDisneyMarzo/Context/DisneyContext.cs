using Microsoft.EntityFrameworkCore;
using PreDisneyMarzo.Models;

namespace PreDisneyMarzo.Context
{
    public class DisneyContext : DbContext
    {
        private const string Schema = "disney";

        public DisneyContext(DbContextOptions<DisneyContext> options) : base(options) 
        {
        }


        // Crear y establecer configuraciones en la base de datos:

        protected override void OnModelCreating (ModelBuilder modelBuilder) 
        {
            base.OnModelCreating (modelBuilder);
            modelBuilder.HasDefaultSchema(Schema);
        }

        //Con qué entidades estaremos trabajando?:

        public DbSet<Genero> Generos { get; set; } = null!;
        public DbSet<Pelicula> Peliculas { get; set; } = null!;
        public DbSet<Personaje> Personajes  { get; set; } = null!;
        }
}
