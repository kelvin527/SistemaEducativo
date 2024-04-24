using EstudiantePrueba.Repositorio;
using System.ComponentModel.DataAnnotations;

namespace EstudiantePrueba.Entidades
{
    public class Maestro:InformacionBasica
    {
        [Required]
        public string GradoObtenido { get; set; }
       
    }
}
