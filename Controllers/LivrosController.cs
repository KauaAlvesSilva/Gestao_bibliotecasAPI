
using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Gestão_bibliotecasAPI.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class LivrosController : ControllerBase
    {
        private readonly ILivroService _service;
        public LivrosController(ILivroService service)
        {
            _service = service;
        }

        [HttpPost("Criar/{livro}")]
        public async Task<IActionResult> Criar([FromBody] Livro livro) 
        {
            return Ok(await _service.CriarAsync(livro));
        }

        [HttpGet("Obter/{id}")]
        public async Task<IActionResult> Obter(int id) 
        { 
            return Ok(await _service.ObterPorIdAsync(id));
        }

        [HttpGet("Listar")]
        public async Task<IActionResult> Listar()
        { 
            return Ok(await _service.ListarAsync());
        } 
    }
}
