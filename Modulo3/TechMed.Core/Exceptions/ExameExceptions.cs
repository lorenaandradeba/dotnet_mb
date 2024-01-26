using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechMed.Core.Exceptions
{
    public class ExameExceptions: Exception
    {
        public ExameExceptions() :
            base("Exame não encontrado.")
        {
        }
        
    }
}