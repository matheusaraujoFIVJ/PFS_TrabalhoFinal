using Microsoft.AspNetCore.Mvc;
using JudoAPI.Data;
using JudoAPI.Models;

namespace JudocaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly JudoContext _context;

        public UsuarioController(JudoContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_context.Usuarios.ToList());
        }

        [HttpPost]
        public IActionResult Create(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetAll), new { id = usuario.Id }, usuario);
        }


    }
}
