using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechFit.Core.Entities;

public class Exercicio
{

    public int ExercicioId { get; set; }
    public required string GrupoMuscular { get; set; }
    public int Series { get; set; }
    public int Repeticoes { get; set; }
    public int TempoIntervaloSegundos { get; set; }

}
