using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Backend.Data;
using Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend.Controllers
{
    [Route("api/v1/users")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UsuariosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Listar usuarios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Usuario>>> GetUsuarios()
        {
            return await _context.usuarios.ToListAsync();
        }

        // Mostrar usuario
        [HttpGet("{id_user}")]
        public async Task<ActionResult<Usuario>> GetUsuario(int id_user)
        {
            var usuario = await _context.usuarios.FindAsync(id_user);

            if (usuario == null)
            {
                return NotFound();
            }

            return usuario;
        }

        // Añadir usuario
        [HttpPost]
        public async Task<ActionResult<Usuario>> PostUsuario(Usuario usuario)
        {
            _context.usuarios.Add(usuario);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUsuario", new { id_user = usuario.Id }, usuario);
        }

        // Modificar usuario
        [HttpPut("{id_user}")]
        public async Task<IActionResult> PutUsuario(int id_user, Usuario usuario)
        {
            if (id_user != usuario.Id)
            {
                return BadRequest();
            }

            _context.Entry(usuario).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // Borrar usuario
        [HttpDelete("{id_user}")]
        public async Task<IActionResult> DeleteUsuario(int id_user)
        {
            var usuario = await _context.usuarios.FindAsync(id_user);
            if (usuario == null)
            {
                return NotFound();
            }

            _context.usuarios.Remove(usuario);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
