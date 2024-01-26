using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechMed.Application.Services.Interfaces;
using TechMed.Application.ViewModels;

namespace TechMed.WebAPI.Controllers
{
    [ApiController]
    [Route("/api/v0.1/")]
    public class ExameController : Controller
    {
                
        private readonly IExameService _exameService;
        public List<ExameViewModel> Exames => _exameService.GetAll();
        public ExameController(IExameService service) => _exameService = service;
        [HttpGet("exames")]
        public IActionResult Get()
        {
            return Ok(Exames);

        }

    }
}