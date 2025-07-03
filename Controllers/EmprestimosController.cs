using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Gestão_bibliotecasAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmprestimosController : ControllerBase
    {
        private readonly IEmprestimoService _service;
        public EmprestimosController(IEmprestimoService service)
        {
            _service = service;
        }

        [HttpPost("Solicitar/{livroId}")]
        public async Task<IActionResult> Solicitar(int livroId)
        {

           var resultado = await _service.SolicitarAsync(livroId);
            return Ok(resultado);
           
        }

        [HttpPost("Devolver/{id}")]
        public async Task<IActionResult> Devolver(int id)
        {
            var resultado = await _service.DevolverAsync(id);
            return Ok(resultado);
        }

        [HttpGet("Listar")]
        public async Task<IActionResult> Listar() 
        {
            return Ok(await _service.ListarAsync());
        } 
    }
}
