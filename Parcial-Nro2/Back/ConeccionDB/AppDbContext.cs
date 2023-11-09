
using Back.Clases;
using Microsoft.EntityFrameworkCore;

namespace Back.ConeccionDB
{
    public class AppDbContext : DbContext
    {
        public DbSet<Profesor> Profesores { get; set; }
        public DbSet<Alumno> Alumnos { get; set; }
        
        public DbSet<Curso> Cursos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = LAPTOP-64KVEN22; database = GestionEscuela; trusted_connection = true; Encrypt = False");
        }
    }
}
