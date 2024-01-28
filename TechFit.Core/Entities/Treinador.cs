using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechFit.Core.Entities;

public class Treinador : Pessoa
{
    public int TreinadorId { get; set; }
    public string? CPF { get; set; }
    public string? CREF { get; set; }
}
