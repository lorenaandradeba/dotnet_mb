
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechFit.Core.Entities;
using TechFit.Infrastructure.Persistence.Interfaces;

namespace TechFit.Infrastructure.Persistence
{
    public class ExercicioDB : IExercicioCollection

    {

        private readonly List<Exercicio> _exercicios = new List<Exercicio>();
        private int _id = 0;
        public int Create(Exercicio exercicio)
        {
            if(_exercicios.Count>0)
                _id = _exercicios.Max(e => e.ExercicioId);

            exercicio.ExercicioId = ++_id;

            _exercicios.Add(exercicio);

            return exercicio.ExercicioId;
        }

        public void Delete(int id)
        {
            _exercicios.RemoveAll(e => e.ExercicioId == id);
        }

        public ICollection<Exercicio> GetAll()
        {
            return _exercicios.ToArray();
        }

        public Exercicio? GetById(int id)
        {
            
            return _exercicios.FirstOrDefault(e => e.ExercicioId == id);
        }

        public void Update(int id, Exercicio exercicio)
        {
            var exercicioDB = _exercicios.FirstOrDefault(e => e.ExercicioId == id);

            if (exercicioDB is not null)
            {
                exercicioDB.GrupoMuscular = exercicio.GrupoMuscular;
                exercicioDB.Series = exercicio.Series;
                exercicioDB.Repeticoes = exercicio.Repeticoes;
                exercicioDB.TempoIntervaloSegundos = exercicio.TempoIntervaloSegundos;
            }
        }

    }
}