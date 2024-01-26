using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechMed.Core.Entities;
using TechMed.Infrastructure.Persistence.Interfaces;

namespace TechMed.Infrastructure.Persistence
{
    public class ExameDB : IExameCollection
    {

        private readonly List<Exame> _exames = new List<Exame>();
        private int _id = 0;

        public int Create(Exame exame)
        {
            if(_exames.Count > 0)
                _id = _exames.Max(m => m.ExameId);
            exame.ExameId = ++_id;
            _exames.Add(exame);
            return exame.ExameId;
        }

        public void Delete(int id)
        {
            _exames.RemoveAll(e => e.ExameId == id);
        }

        public ICollection<Exame> GetAll()
        {
            return _exames.ToArray();
        }

        public Exame? GetById(int id)
        {
            return _exames.FirstOrDefault(e => e.ExameId == id);
        }

        public void Update(int id, Exame exame)
        {
            var ExameDB = _exames.FirstOrDefault(e => e.AtendimentoId == id);
            if(ExameDB is not null)
            {
                ExameDB.DataHora = exame.DataHora;
            }
        }
    }
}