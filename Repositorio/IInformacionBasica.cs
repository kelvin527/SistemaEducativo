using System.ComponentModel.DataAnnotations;

namespace EstudiantePrueba.Repositorio
{
    public interface IInformacionBasica
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
        public string  Direccion{ get; set; }
        [Required]
        public bool Sexo { get; set; }
    }
}
