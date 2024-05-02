using AutoMapper;
using EstudiantePrueba.DTOS;
using EstudiantePrueba.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EstudiantePrueba.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudianteController : ControllerBase
    {
        private readonly ContextDB contextDB;
        private readonly IMapper mapper;

        public EstudianteController(ContextDB contextDB, IMapper mapper)
        {
            this.contextDB = contextDB;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<EstudianteDTO>>> GetAll()
        {
            var estudiante = await contextDB.Estudiantes.AsNoTracking().ToListAsync();

            return mapper.Map<List<EstudianteDTO>>(estudiante);
        }
    }
}
