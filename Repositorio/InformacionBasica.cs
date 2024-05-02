using System.ComponentModel.DataAnnotations;

namespace EstudiantePrueba.Repositorio
{
    public class InformacionBasica 
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(150)]
        public string Nombre { get; set; }
        [Required]
        [MaxLength(200)]
        public string Apellido { get; set; }
        [Required]
        public int Edad { get; set; }
        [Required]
        [MaxLength(200)]
        public string Direccion { get; set; }
        [Required]
        public int Sexo { get; set; }
    }
}