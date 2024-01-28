using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechFit.Application.Services.Interfaces;
using TechFit.Infrastructure.Persistence;
using TechFit.Infrastructure.Persistence.Interfaces;

namespace TechFit.Infra.Persistence
{
    public class TechFitContext : ITechFitContext, IDatabaseFake
    {
        public IClienteCollection ClientesCollection { get; } = new ClienteDB();
        public ITreinadorCollection TreinadorCollection { get; } = new TreinadorDB();
        public IExercicioCollection ExerciciosCollection { get; } = new ExercicioDB();
        public ITreinoCollection TreinosCollection { get; } = new TreinoDB();
        public IClienteTreinoCollection ClientesTreinosCollection { get; } = new ClienteTreinoDB();
    }
}