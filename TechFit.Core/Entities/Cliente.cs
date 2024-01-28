using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechFit.Core.Entities;

public class Cliente : Pessoa
{
    public int ClienteId { get; set; }
    public List<ClienteTreino>? TreinosAssociados { get; set; }
    public string? CPF { get; set; }
    public double Altura { get; set; }
    public double Peso { get; set; }


}
