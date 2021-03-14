using APIConsulta.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIConsulta.Data.Mapping
{
    public class ConsultaMap : IEntityTypeConfiguration<Consulta>
    {
        public void Configure(EntityTypeBuilder<Consulta> builder)
        {
            builder.ToTable("CONSULTA");
            builder.HasKey(consulta => consulta.ConsultaId);


            builder.HasOne<Medico>(consulta => consulta.Medico)
                   .WithMany(medico => medico.Consultas)
                   .HasForeignKey(consulta => consulta.MedicoId);


            builder.HasOne<Paciente>(consulta => consulta.Paciente)
                   .WithMany(paciente => paciente.Consultas)
                   .HasForeignKey(consulta => consulta.PacienteId);

            builder.HasOne<Status>(consulta => consulta.Status)
                   .WithMany(status => status.Consultas)
                   .HasForeignKey(consulta => consulta.StatusId);
        }

    }
}
