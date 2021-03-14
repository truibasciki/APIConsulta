using APIConsulta.Data.Context;
using APIConsulta.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIConsulta.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class EspecialidadesController : ControllerBase
    {
        private ConsultaContext _context;
        public EspecialidadesController(ConsultaContext context)
        {
            _context = context;
        }
        // GET: api/<EspecialidadesController>
        [HttpGet]
        public IEnumerable<Especialidade> Get()
        {
            return _context.Especialidades.Include(especialidade => especialidade.Medicos);
        }

    }
}
