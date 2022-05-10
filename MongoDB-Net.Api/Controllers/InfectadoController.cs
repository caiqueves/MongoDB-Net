using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MongoDB_Net.Application.DTOs;
using MongoDB_Net.Application.Interfaces;
using MongoDB_Net.Domain.Entities;

namespace MongoDB_Net.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class InfectadoController : ControllerBase
    {
        private readonly IInfectadoService _infectadoService;
        public InfectadoController(IInfectadoService infectadoService)
        {
            _infectadoService = infectadoService;
        }

        [HttpPost]
        public ActionResult SalvarInfectado([FromBody] InfectadoDTO dto)
        {
            _infectadoService.Add(dto);

            return StatusCode(201, "Infectado adicionado com sucesso");
        }
    }
}
