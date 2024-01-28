using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechFit.Application.Services.Interfaces;
using TechFit.Core.Entities;

namespace TechFit.Infra.Persistence
{
    public class ClienteDB : IClienteCollection
    {
        private readonly List<Cliente> _clientes = new List<Cliente>();
        private int _id = 0;

        public int Create(Cliente cliente)
        {

            //Verifica se existe cliente
            if (_clientes.Count > 0)
                _id = _clientes.Max(c => c.ClienteId);//Para pegar o id do maior

            //Atribui o ClienteId para seguir a sequencia
            cliente.ClienteId = ++_id;


            //Adiciona novo Cliente ao List
            _clientes.Add(cliente);

            //Retorna o ClienteId no Cliente adcionado
            return cliente.ClienteId;
        }

        public void Delete(int id)
        {
            _clientes.RemoveAll(c => c.ClienteId == id);
        }

        public ICollection<Cliente> GetAll()
        {
            return _clientes.ToArray();
        }

        public Cliente? GetById(int id)
        {
            return _clientes.FirstOrDefault(c => c.ClienteId == id);
        }

        public void Update(int id, Cliente cliente)
        {
            var clienteDB = _clientes.FirstOrDefault(c => c.ClienteId == id);
            if (clienteDB is not null)
            {
                clienteDB.Nome = cliente.Nome;
            }

        }
    }
}