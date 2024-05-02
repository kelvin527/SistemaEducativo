using EstudiantePrueba.Repositorio;
using System.ComponentModel.DataAnnotations;

namespace EstudiantePrueba.DTOS
{
    public class EstudianteDTO:InformacionBasica
    {
       
        public string Curso { get; set; }
    }
}
