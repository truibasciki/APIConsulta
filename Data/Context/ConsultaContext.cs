using APIConsulta.Data.Mapping;
using APIConsulta.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIConsulta.Data.Context
{
    public class ConsultaContext : DbContext
    {
        public ConsultaContext(DbContextOptions<ConsultaContext> options)
          : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Consulta>(new ConsultaMap().Configure);
            builder.Entity<Especialidade>(new EspecialidadeMap().Configure);
        }

        public DbSet<Models.Consulta> Consultas { get; set; }
        public DbSet<Models.Especialidade> Especialidades { get; set; }
        public DbSet<Models.Medico> Medicos { get; set; }
        public DbSet<Models.Paciente> Pacientes { get; set; }
        public DbSet<Models.Status> Status { get; set; }
    }
}
