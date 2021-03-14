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
    [Route("api/status")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        private ConsultaContext _context;
        public StatusController(ConsultaContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Status> Get()
        {
            return _context.Status.Include(status => status.Consultas).ThenInclude(consulta => consulta.Paciente).Include(status => status.Consultas).ThenInclude(consulta => consulta.Medico).ThenInclude(medico => medico.Especialidade);
        }
    }
}
