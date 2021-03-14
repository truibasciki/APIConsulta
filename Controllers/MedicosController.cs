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
    [Route("api/medicos")]
    [ApiController]
    public class MedicosController : ControllerBase
    {
        private ConsultaContext _context;
        public MedicosController(ConsultaContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public IEnumerable<Medico> Get()
        {
            return _context.Medicos.Include(medico => medico.Especialidade).Include(medico => medico.Consultas).ThenInclude(consulta => consulta.Paciente).Include(medico => medico.Consultas).ThenInclude(consulta => consulta.Status);
        }
    }
}
