using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechFit.Application.InputModels;
using TechFit.Application.Services.Interfaces;
using TechFit.Application.ViewModels;
using TechFit.Core.Entities;

namespace TechFit.Application.Services;
public class ClienteService : IClienteService
{

    private readonly ITechFitContext _context;
    public ClienteService(ITechFitContext context)
    {
        _context = context;
    }
    public int Create(NewClienteInputModel cliente)
    {
        return _context.ClientesCollection.Create(new Cliente
            {
                Nome = cliente.Nome
            });
    }

        public void Delete(int id)
        {
            _context.ClientesCollection.Delete(id);
        }

        public List<ClienteViewModel> GetAll()
        {
            var clientes = _context.ClientesCollection.GetAll().Select(c => new ClienteViewModel
            {
                ClienteId = c.ClienteId,
                Nome = c.Nome
            }).ToList();

            return clientes;
        }

        public ClienteViewModel? GetById(int id)
        {
            var cliente = _context.ClientesCollection.GetById(id);

            if (cliente is null)
                return null;

            var clienteViewModel = new ClienteViewModel
            {
                ClienteId = cliente.ClienteId,
                Nome = cliente.Nome
            };
            return clienteViewModel;
        }

        public void Update(int id, NewClienteInputModel cliente)
        {
            _context.ClientesCollection.Update(id, new Cliente
            {
                Nome = cliente.Nome
            });
        }
}