using System.ComponentModel.DataAnnotations.Schema;

namespace EstudiantePrueba.Entidades
{
    public class Asistencia
    {
        public int Id { get; set; }
        public string EstudianteId { get; set; }
        public Estudiante Estudiante { get; set; }
        [Column(TypeName = "Date")]
        public DateTime Fecha { get; set; }
    }
}
