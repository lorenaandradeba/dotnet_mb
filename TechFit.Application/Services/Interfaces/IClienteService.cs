using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechFit.Application.InputModels;
using TechFit.Application.ViewModels;

namespace TechFit.Application.Services.Interfaces
{
    public interface IClienteService
    {
        
      public List<ClienteViewModel> GetAll();
      public ClienteViewModel? GetById(int id);
      public int Create(NewClienteInputModel cliente);
      public void Update(int id, NewClienteInputModel cliente);
      public void Delete(int id);
    }
}