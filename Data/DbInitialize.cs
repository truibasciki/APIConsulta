using APIConsulta.Data.Context;
using APIConsulta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIConsulta.Data
{
    public class DbInitialize
    {
        public static void Initialize(ConsultaContext context)
        {
            context.Database.EnsureCreated();

            if (!context.Pacientes.Any())
            {
                var pacientes = new Paciente[]
                {
                    new Paciente{Nome="João Silva",Email="joao.silva@hotmail.com",Senha="4321",Telefone="11 99999-9999"},
                    new Paciente{Nome="Alberto Borges",Email="alberto.borges@gmail.com",Senha="4567",Telefone="11 99999-9998"},
                    new Paciente{Nome="Regina Soares",Email="regina.soares@live.com",Senha="1234",Telefone="11 99999-9997"}
                };
                foreach (Paciente p in pacientes)
                {
                    context.Pacientes.Add(p);
                }
                context.SaveChanges();
            }

            if (!context.Especialidades.Any())
            {
                var especialidades = new Especialidade[]
                {
                    new Especialidade{Nome="Psicologia"},
                    new Especialidade{Nome="Nutrição"},
                };
                foreach (Especialidade e in especialidades)
                {
                    context.Especialidades.Add(e);
                }
                context.SaveChanges();
            }

            if (!context.Medicos.Any())
            {
                var medicos = new Medico[]
                {
                    new Medico{Nome="Rafael Couto", Endereco="Avenida 9 de Julho", EspecialidadeId=1},
                    new Medico{Nome="Nicolas Bastos",Endereco="Avenida Jabaquara", EspecialidadeId=1},
                    new Medico{Nome="José Assunção",Endereco="Avenida Paulista", EspecialidadeId=2}
                };
                foreach (Medico m in medicos)
                {
                    context.Medicos.Add(m);
                }
                context.SaveChanges();
            }

            if (!context.Status.Any())
            {
                var status = new Status[]
                {
                    new Status{Nome="Marcada"},
                    new Status{Nome="Realizada"},
                    new Status{Nome="Cancelada"},
                };
                foreach (Status s in status)
                {
                    context.Status.Add(s);
                }
                context.SaveChanges();
            }


        }
    }
}
