namespace EstudiantePrueba.Entidades
{
    public class Calificacion
    {
        public int Id { get; set; }
        public int EstudianteId { get; set; }
        public int MaestroId { get; set; }
        public int MateriaId { get; set; }
        public int PeriodoId { get; set; }
        public decimal Nota { get; set; }
        public Estudiante Estudiante { get; set; }
        public Maestro Maestro { get; set; }
        public Materia Materia { get; set; }
        public Periodo Periodo { get; set; }
    }
}
