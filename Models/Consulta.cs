using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace APIConsulta.Models
{
    [Table("CONSULTA")]
    public class Consulta
    {
        [Column("ID")]
        public int ConsultaId { get; set; }

        [Required]
        [Column("DATA")]
        public DateTime Data { get; set; }

        [Required]
        [Column("STATUS_FK")]
        public int StatusId { get; set; }

        public virtual Status Status { get; set; }


        [Required]
        [Column("MEDICO_FK")]
        public int MedicoId { get; set; }

        public virtual Medico Medico { get; set; }

        [Required]
        [Column("PACIENTE_FK")]
        public int PacienteId { get; set; }

        public virtual Paciente Paciente { get; set; }

    }
}
