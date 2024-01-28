using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechFit.Application.Services.Interfaces;
using TechFit.Application.ViewModels;

namespace TechFit.WebAPI.Controllers;

[ApiController]
[Route("/api/v0.1/")]
public class ClienteController : ControllerBase
{
    private readonly IClienteService _clienteService;
    public List<ClienteViewModel> Clientes => _clienteService.GetAll();
    public ClienteController(IClienteService service) => _clienteService = service;

    [HttpGet("clientes")]
    public IActionResult Get()
    {
        return Ok(Clientes);
    }
    
}
