using APIConsulta.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIConsulta.Data.Mapping
{
    public class EspecialidadeMap : IEntityTypeConfiguration<Especialidade>
    {
        public void Configure(EntityTypeBuilder<Especialidade> builder)
        {
            builder.ToTable("ESPECIALIDADE");
            builder.HasKey(consulta => consulta.EspecialidadeId);


            builder.HasMany<Medico>(especialidade => especialidade.Medicos)
                   .WithOne(medico => medico.Especialidade)
                   .HasForeignKey(medico => medico.EspecialidadeId);


        }

    }
}
