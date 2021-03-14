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
    [Route("api/consultas")]
    [ApiController]
    public class ConsultasController : ControllerBase
    {
        private ConsultaContext _context;
        public ConsultasController(ConsultaContext context)
        {
            _context = context;
        }
        // GET: api/consultas
        [HttpGet]
        public IEnumerable<Consulta> Get(int? pacienteId, int? medicoId, int? statusId, DateTime? data)
        {

            var consultas = _context.Consultas.Include(consulta => consulta.Paciente).Include(consulta => consulta.Medico).ThenInclude(medico => medico.Especialidade);
            if(pacienteId != null && pacienteId > 0) consultas.Where(consulta => consulta.PacienteId == pacienteId);
            if (medicoId != null && medicoId > 0) consultas.Where(consulta => consulta.MedicoId == medicoId);
            if (statusId != null && statusId > 0) consultas.Where(consulta => consulta.StatusId == statusId);
            if (data != null) consultas.Where(consulta => consulta.Data.Date == data.Value.Date);

            return consultas;
        }

        // GET api/consultas/5
        [HttpGet("{id}")]
        public Consulta Get(int id)
        {
            if (!ConsultaItemExists(id))
            {
                throw new Exception("Consulta não encontrada");
            }            
            return _context.Consultas.Include(consulta => consulta.Paciente).Include(consulta => consulta.Medico).ThenInclude(medico => medico.Especialidade).FirstOrDefault(consulta => consulta.ConsultaId == id);
        }

        // POST api/consultas
        [HttpPost]
        public void Post([FromBody] Consulta consulta)
        {
            _context.Consultas.Add(consulta);
            _context.SaveChanges();

        }

        // PUT api/consultas/5
        [HttpPatch("{id}")]
        public void Patch(int id, [FromBody] int statusId)
        {
            if (!ConsultaItemExists(id))
            {
                throw new Exception("Consulta não encontrada");
            }
            var consulta = _context.Consultas.FirstOrDefault(consulta => consulta.ConsultaId == id);
            consulta.StatusId = statusId;
            _context.Consultas.Update(consulta);
            _context.SaveChanges();
        }

        // DELETE api/consultas/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            if (!ConsultaItemExists(id))
            {
                throw new Exception("Consulta não encontrada");
            }
            _context.Consultas.Remove(_context.Consultas.Find(id));
            _context.SaveChanges();

        }

        private bool ConsultaItemExists(int id) =>
        _context.Consultas.Any(consulta => consulta.ConsultaId == id);

    }
}
