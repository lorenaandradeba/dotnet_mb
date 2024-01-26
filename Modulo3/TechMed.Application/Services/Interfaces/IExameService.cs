using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechMed.Application.InputModels;
using TechMed.Application.ViewModels;

namespace TechMed.Application.Services.Interfaces
{
    public interface IExameService
    {
        public List<ExameViewModel> GetAll();
        public List<ExameViewModel> GetByPacienteId(int pacienteId);
        public List<ExameViewModel> GetByMedicoId(int medicoId);
        public List<ExameViewModel> GetByAtendimentoId(int atendimentoId);
        public int Create(NewExameInputModel exame);
    }
}