using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechFit.Core.Entities;
public class Treino
{

    public int TreinoId { get; set; }
    public string? Tipo { get; set; }
    public string? Objetivo { get; set; }
    public List<Exercicio>? ListaExercicios { get; set; }
    public int DuracaoEstimadaMinutos { get; set; }
    public Treinador? TreinadorResponsavel { get; set; }
    public List<(Cliente, int)>? ClientesAvaliacao { get; set; }
    public List<ClienteTreino>? ClientesAssociados { get; set; }

}