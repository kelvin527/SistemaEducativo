namespace EstudiantePrueba.Entidades
{
    public class MaestroEstudiante
    {
        public int EstudianteId { get; set; }
        public int MestroId { get; set; }
        public List<Estudiante> Estudiantes { get; set; }
        public List<Maestro> Maestros { get; set; }
    }
}
