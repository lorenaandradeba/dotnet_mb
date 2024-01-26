using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechMed.Core.Entities;

namespace TechMed.Application.ViewModels
{
    public class ExameViewModel
    {
      public int ExameId { get; set; }
      public DateTime DataHora { get; set; }
      public string Nome { get; set; } 
      public AtendimentoViewModel Atendimento { get; set; } = null!;
      public PacienteViewModel Paciente{ get; set; } = null!;
      public MedicoViewModel Medico{ get; set; } = null!;

    }
}