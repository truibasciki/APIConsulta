using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace APIConsulta.Models
{
    [Table("ESPECIALIDADE")]
    public class Especialidade
    {
        [Column("ID")]
        public int EspecialidadeId { get; set; }

        [Required]
        [Column("NOME")]
        [MaxLength(50)]
        public string Nome { get; set; }

        public virtual ICollection<Medico> Medicos { get; set; }
    }
}
