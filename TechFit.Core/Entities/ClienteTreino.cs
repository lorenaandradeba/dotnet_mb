using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechFit.Core.Entities;

public class ClienteTreino
{
    public int ClienteTreinoId { get; set; }
    public Cliente? Cliente { get; set; }
    public Treino? Treino { get; set; }
    public DateTime DataInicio { get; set; }
    public int VencimentoDias { get; set; }
}
