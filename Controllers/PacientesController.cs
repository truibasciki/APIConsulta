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
    [Route("api/pacientes")]
    [ApiController]
    public class PacientesController : ControllerBase
    {
        private ConsultaContext _context;
        public PacientesController(ConsultaContext context)
        {
            _context = context;
        }
        // GET: api/<PacienteController>
        [HttpGet]
        public IEnumerable<Paciente> Get()
        {
            return _context.Pacientes.Include(paciente => paciente.Consultas).ThenInclude(consulta => consulta.Status).Include(paciente => paciente.Consultas).ThenInclude(consulta => consulta.Medico).ThenInclude(medico => medico.Especialidade);
        }

    }
}
