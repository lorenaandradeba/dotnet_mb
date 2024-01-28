
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechFit.Core.Entities;
using TechFit.Infrastructure.Persistence.Interfaces;

namespace TechFit.Infrastructure.Persistence
{
    public class TreinadorDB : ITreinadorCollection
    {


        private readonly List<Treinador> _treinadores = new List<Treinador>();
        private int _id = 0;
        public int Create(Treinador treinador)
        {
            if (_treinadores.Count > 0)
                _id = _treinadores.Max(t => t.TreinadorId);

            treinador.TreinadorId = ++_id;

            _treinadores.Add(treinador);

            return treinador.TreinadorId;
        }

        public void Delete(int id)
        {
            _treinadores.RemoveAll(t => t.TreinadorId == id);
        }

        public ICollection<Treinador> GetAll()
        {
            return _treinadores.ToArray();
        }

        public Treinador? GetById(int id)
        {
            return _treinadores.FirstOrDefault(t => t.TreinadorId == id);
        }

        public void Update(int id, Treinador treinador)
        {
             var treinadorDB = _treinadores.FirstOrDefault(t => t.TreinadorId == id);
            if (treinadorDB is not null)
            {
                treinadorDB.Nome = treinador.Nome;
                treinadorDB.CPF = treinador.CPF;
                treinadorDB.CREF = treinador.CREF;
            }
        }
    }
}