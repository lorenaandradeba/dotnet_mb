using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace TechFit.Core.Entities;

public class Pessoa
{
   // private DateTime _dtNascimento;
    public required string Nome { get; set; }
    public DateTime DtNascimento;
    public int Idade { get; set; }

}
