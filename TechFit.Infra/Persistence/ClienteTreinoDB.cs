
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechFit.Core.Entities;
using TechFit.Infrastructure.Persistence.Interfaces;

namespace TechFit.Infrastructure.Persistence
{
    public class ClienteTreinoDB : IClienteTreinoCollection
    {

        private readonly List<ClienteTreino> _clienteTreinos = new List<ClienteTreino>();
        private int _id = 0;
        public int Create(ClienteTreino clienteTreino)
        {
            if (_clienteTreinos.Count > 0)
                _id = _clienteTreinos.Max(ctr => ctr.ClienteTreinoId);

            clienteTreino.ClienteTreinoId = ++_id;

            _clienteTreinos.Add(clienteTreino);

            return clienteTreino.ClienteTreinoId;
        }

        public void Delete(int id)
        {
            _clienteTreinos.RemoveAll(ctr => ctr.ClienteTreinoId == id);
        }

        public ICollection<ClienteTreino> GetAll()
        {
            return _clienteTreinos.ToArray();
        }

        public ClienteTreino? GetById(int id)
        {
            return _clienteTreinos.FirstOrDefault(ctr => ctr.ClienteTreinoId == id);
        }
        public ICollection<Treino>? GetByClienteId(int clienteId)
        {
            // Usa o Where para obter List<ClienteTreino> com o id do cliente igual ao parâmetro clienteId
            // Usa o Select para obter List<Treino> desses elementos
            return _clienteTreinos.Where(ctr => ctr.Cliente?.ClienteId == clienteId).Select(t => t.Treino ?? new Treino()).ToList();
        }

        public ICollection<Cliente>? GetByTreinoId(int treinoId)
        {
            return _clienteTreinos.Where(ctr => ctr.Treino?.TreinoId == treinoId).Select(c => c.Cliente ?? new Cliente { Nome = "" }).ToList();
        }

        public void Update(int id, ClienteTreino clienteTreino)
        {
            var clienteTreinoDB = _clienteTreinos.FirstOrDefault(c => c.ClienteTreinoId == id);

            if (clienteTreinoDB is not null)
            {
                clienteTreinoDB.DataInicio = clienteTreino.DataInicio;
                clienteTreinoDB.VencimentoDias = clienteTreino.VencimentoDias;
                clienteTreinoDB.Treino = clienteTreino.Treino;
                clienteTreinoDB.Cliente = clienteTreino.Cliente;
            }
        }
    }
}