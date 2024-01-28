using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechFit.Core.Entities;
using TechFit.Infrastructure.Persistence.Interfaces;

namespace TechFit.Infrastructure.Persistence
{
    public class TreinoDB : ITreinoCollection
    {
        private readonly List<Treino> _treinos = new List<Treino>();
        private int _id = 0;
        public int Create(Treino treino)
        {

            if (_treinos.Count > 0)
                _id = _treinos.Max(t => t.TreinoId);

            treino.TreinoId = ++_id;

            _treinos.Add(treino);
            return treino.TreinoId;
        }

        public void Delete(int id)
        {
            _treinos.RemoveAll(t => t.TreinoId == id);
        }

        public ICollection<Treino> GetAll()
        {
            return _treinos.ToArray();
        }

        public Treino? GetById(int id)
        {
            return _treinos.FirstOrDefault(t => t.TreinoId == id);
        }

        public void Update(int id, Treino treino)
        {
            var treinoDB = _treinos.FirstOrDefault(t => t.TreinoId == id);
            if (treinoDB is not null)
            {
                treinoDB.Tipo = treino.Tipo;
                treinoDB.Objetivo = treino.Objetivo;
                treinoDB.DuracaoEstimadaMinutos = treino.DuracaoEstimadaMinutos;
                treinoDB.ListaExercicios = treino.ListaExercicios;
            }
        }
    }
}