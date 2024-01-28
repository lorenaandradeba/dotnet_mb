using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechFit.Infrastructure.Persistence.Interfaces;

namespace TechFit.Application.Services.Interfaces
{
    public interface IDatabaseFake
    {

        public IClienteCollection ClientesCollection { get; }
        public ITreinadorCollection TreinadorCollection { get; }
        public IExercicioCollection ExerciciosCollection { get; }
        public ITreinoCollection TreinosCollection { get; }
        public IClienteTreinoCollection ClientesTreinosCollection { get; }
    }
}