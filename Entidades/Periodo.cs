using System.ComponentModel.DataAnnotations;

namespace EstudiantePrueba.Entidades
{
    public class Periodo
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string PeriodoEvaluacion { get; set; }
    }
}
