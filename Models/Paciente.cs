using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace APIConsulta.Models
{
    [Table("PACIENTE")]
    public class Paciente
    {
        [Column("ID")]
        public int PacienteId { get; set; }

        [Required]
        [Column("NOME")]
        [MaxLength(200)]
        public string Nome { get; set; }

        [Required]
        [Column("TELEFONE")]
        [MaxLength(200)]
        public string Telefone { get; set; }

        [Required]
        [Column("EMAIL")]
        [MaxLength(200)]
        public string Email { get; set; }

        [Required]
        [Column("SENHA")]
        [MaxLength(200)]
        public string Senha { get; set; }

        public virtual ICollection<Consulta> Consultas { get; set; }
    }
}
