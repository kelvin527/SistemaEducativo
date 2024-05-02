using Microsoft.EntityFrameworkCore;

namespace EstudiantePrueba.Entidades
{
    public class ContextDB : DbContext
    {
        public ContextDB(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Maestro> Maestro { get; set; }
        public DbSet<Asistencia> Asistencia { get; set;}
        public DbSet<Materia> Materia { get; set; }
        public DbSet<Periodo> Periodo { get; set; }
        public DbSet<Calificacion> Calificaciones { get; set; }

    }
}
