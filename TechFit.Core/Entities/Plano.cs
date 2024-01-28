using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechFit.Core.Entities;

public class Plano
{

    
    public int PlanoId { get; set; }
    public string Titulo { get; set; }
    public double Valor { get; set; }

    public Plano(string titulo, double valor)
    {
        Titulo = titulo;
        Valor = valor;
    }

}
