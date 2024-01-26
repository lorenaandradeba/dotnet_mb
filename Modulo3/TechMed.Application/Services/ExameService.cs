using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechMed.Application.InputModels;
using TechMed.Application.Services.Interfaces;
using TechMed.Application.ViewModels;
using TechMed.Core.Entities;
using TechMed.Infrastructure.Persistence.Interfaces;

namespace TechMed.Application.Services
{
    public class ExameService:  BaseService, IExameService
    {
        private readonly IMedicoService _medicoService;
        // private readonly ITechMedContext _context;
        // public ExameService(ITechMedContext context)
        // {
        //     _context = context;
        // }

        public ExameService(ITechMedContext context, IMedicoService medico) : base(context)
        {
            _medicoService = medico;
        }
        public int Create(NewExameInputModel exame)
        {
            return _medicoService.CreateExame(exame.AtendimentoId, exame);
        }

        public List<ExameViewModel> GetAll()
        {
           return _context.ExameCollection.GetAll().Select(e => new ExameViewModel
            {
                ExameId = e.ExameId, 
                DataHora = e.DataHora,
                Nome = e.Nome,
                Medico = new MedicoViewModel
                {
                    MedicoId = e.Atendimento.MedicoId,
                    Nome = e.Atendimento.Medico.Nome
                },
                Paciente = new PacienteViewModel
                {
                    PacienteId = e.Atendimento.PacienteId,
                    Nome = e.Atendimento.Paciente.Nome
                }
            }).ToList();
        }

        public List<ExameViewModel> GetByAtendimentoId(int atendimentoId)
        {
            throw new NotImplementedException();
        }

        public List<ExameViewModel> GetByMedicoId(int medicoId)
        {
            throw new NotImplementedException();
        }

        public List<ExameViewModel> GetByPacienteId(int pacienteId)
        {
            throw new NotImplementedException();
        }
    }
}