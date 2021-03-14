using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace APIConsulta.Models
{
    [Table("MEDICO")]
    public class Medico
    {
        [Column("ID")]
        public int MedicoId { get; set; }

        [Required]
        [Column("NOME")]
        [MaxLength(200)]
        public string Nome { get; set; }

        [Required]
        [Column("ENDERECO")]
        [MaxLength(200)]
        public string Endereco { get; set; }

        [Required]
        [Column("ESPECIALIDADE_FK")]
        public int EspecialidadeId { get; set; }

        public virtual Especialidade Especialidade { get; set; }

        public virtual ICollection<Consulta> Consultas { get; set; }
    }
}
