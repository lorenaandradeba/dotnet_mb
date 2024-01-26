using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechMed.Application.InputModels
{
    public class NewExameInputModel
    {

      public int AtendimentoId { get; set; }
      public DateTime DataHora { get; set; }
      public string Nome { get; set; }
        
    }
}