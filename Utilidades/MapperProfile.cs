using AutoMapper;
using EstudiantePrueba.DTOS;
using EstudiantePrueba.Entidades;

namespace EstudiantePrueba.Utilidades
{
    public class MapperProfile:Profile
    {
        public MapperProfile()
        {
            CreateMap<Estudiante, EstudianteDTO>();
        }

        
    }
}
