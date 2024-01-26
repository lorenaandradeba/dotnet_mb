using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechMed.Core.Exceptions
{
    public class AtendimentoExceptions : Exception
    {
        public AtendimentoExceptions() : 
            base("Atendimento não encontrado.")
            {}
    }
}