using TechMed.Application.Services.Interfaces;
using TechMed.Application.InputModels;
using TechMed.Application.ViewModels;
using TechMed.Infrastructure.Persistence.Interfaces;
using TechMed.Core.Entities;
using TechMed.Core.Exceptions;

namespace TechMed.Application.Services;
public class MedicoService : IMedicoService
{
  private readonly ITechMedContext _context;
  public MedicoService(ITechMedContext context)
  {
    _context = context;
  }

  public int Create(NewMedicoInputModel medico)
  {
    return _context.MedicosCollection.Create(new Medico
    {
      Nome = medico.Nome
    });

  }

  public int CreateAtendimento(int medicoId, NewAtendimentoInputModel atendimento)
  {
    var medico = _context.MedicosCollection.GetById(medicoId);
    if (medico is null)
      throw new MedicoNotFoundException();

    var paciente = _context.PacientesCollection.GetById(atendimento.PacienteId);
    if (paciente is null)
      throw new PacienteNotFoundException();

    return _context.AtendimentosCollection.Create(new Atendimento
    {
      DataHora = atendimento.DataHora,
      Medico = medico,
      Paciente = paciente
    });
  }
  public int CreateExame(int atendimentoId, NewExameInputModel exame)
  {
    // var medico = _context.MedicosCollection.GetById(atendimento.MedicoId);
    // if (medico is null)
    //   throw new MedicoNotFoundException();

    // var paciente = _context.PacientesCollection.GetById(exame.PacienteId);
    // if (paciente is null)
    //   throw new PacienteNotFoundException();

    var atendimentoDB = _context.AtendimentosCollection.GetById(atendimentoId);
     if (atendimentoDB is null)
      throw new AtendimentoExceptions();

    return _context.ExameCollection.Create(new Exame
    {
      DataHora = exame.DataHora,
      Atendimento = atendimentoDB
    });
  }

  public void Delete(int id)
  {
    _context.MedicosCollection.Delete(id);
  }

  public List<MedicoViewModel> GetAll()
  {
    var medicos = _context.MedicosCollection.GetAll().Select(m => new MedicoViewModel
    {
      MedicoId = m.MedicoId,
      Nome = m.Nome
    }).ToList();

    return medicos;

  }

  public MedicoViewModel? GetByCrm(string crm)
  {
    throw new NotImplementedException();
  }

  public MedicoViewModel? GetById(int id)
  {
    var medico = _context.MedicosCollection.GetById(id);

    if (medico is null)
      return null;

    var MedicoViewModel = new MedicoViewModel
    {
      MedicoId = medico.MedicoId,
      Nome = medico.Nome
    };
    return MedicoViewModel;
  }

  public void Update(int id, NewMedicoInputModel medico)
  {
    _context.MedicosCollection.Update(id, new Medico
    {
      Nome = medico.Nome
    });
  }
}
