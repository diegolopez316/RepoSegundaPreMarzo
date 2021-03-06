// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PreDisneyMarzo.Context;

#nullable disable

namespace PreDisneyMarzo.Migrations
{
    [DbContext(typeof(DisneyContext))]
    [Migration("20220314212208_Primera")]
    partial class Primera
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("disney")
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PeliculaPersonaje", b =>
                {
                    b.Property<int>("PeliculaListId")
                        .HasColumnType("int");

                    b.Property<int>("PersonajeListId")
                        .HasColumnType("int");

                    b.HasKey("PeliculaListId", "PersonajeListId");

                    b.HasIndex("PersonajeListId");

                    b.ToTable("PeliculaPersonaje", "disney");
                });

            modelBuilder.Entity("PreDisneyMarzo.Models.Genero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Imagen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Generos", "disney");
                });

            modelBuilder.Entity("PreDisneyMarzo.Models.Pelicula", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Calificacion")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaDeCreacion")
                        .HasColumnType("datetime2");

                    b.Property<int?>("GeneroId")
                        .HasColumnType("int");

                    b.Property<string>("Imagen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GeneroId");

                    b.ToTable("Peliculas", "disney");
                });

            modelBuilder.Entity("PreDisneyMarzo.Models.Personaje", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<string>("Historia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Imagen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Peso")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Personajes", "disney");
                });

            modelBuilder.Entity("PeliculaPersonaje", b =>
                {
                    b.HasOne("PreDisneyMarzo.Models.Pelicula", null)
                        .WithMany()
                        .HasForeignKey("PeliculaListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PreDisneyMarzo.Models.Personaje", null)
                        .WithMany()
                        .HasForeignKey("PersonajeListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PreDisneyMarzo.Models.Pelicula", b =>
                {
                    b.HasOne("PreDisneyMarzo.Models.Genero", null)
                        .WithMany("PeliculaList")
                        .HasForeignKey("GeneroId");
                });

            modelBuilder.Entity("PreDisneyMarzo.Models.Genero", b =>
                {
                    b.Navigation("PeliculaList");
                });
#pragma warning restore 612, 618
        }
    }
}
