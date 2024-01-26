using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechMed.Core.Entities
{
    public class Exame
    {
        public int ExameId { get; set; }
        public string Nome { get; set; }
        public DateTime DataHora { get; set; }
        public int MedicoId { get; set; }
        public  Medico? Medico { get; set; }
        public int PacienteId { get; set; }
        public  Paciente? Paciente {get; set;}
        public int AtendimentoId { get; set; }
        public required Atendimento Atendimento {get; set;}  
    }
}