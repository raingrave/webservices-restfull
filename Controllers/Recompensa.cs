using Microsoft.AspNetCore.Mvc;
using WebServiceRestfull.Data;
using WebServiceRestfull.Entities;
using WebServiceRestfull.Enums;

namespace WebServiceRestfull.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecompensaController : ControllerBase
    {
        private RecompensaContext _context;

        public RecompensaController()
        {
            _context = new RecompensaContext();
        }

        [HttpGet]
        public IActionResult FindAll()
        {
            return Ok(_context.Recompensas);
        }

        [HttpGet("{id}")]
        public IActionResult FindById(int id)
        {
            Recompensa recompensa = _context.Recompensas.FirstOrDefault(recompensa => recompensa.Id == id);

            if (recompensa != null)
            {
                return Ok(recompensa);
            }

            return NotFound();
        }

        [HttpPost]
        public IActionResult Create([FromBody] Recompensa recompensa)
        {
            _context.Recompensas.Add(recompensa);

            _context.SaveChanges();

            return CreatedAtAction(nameof(FindById), new { Id = recompensa.Id }, recompensa);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Recompensa recompensa)
        {
            Recompensa recompensaRecuperado = _context.Recompensas.FirstOrDefault(recompensa => recompensa.Id == id);

            if (recompensaRecuperado != null)
            {
                recompensaRecuperado.ExercicioRealizado = recompensa.ExercicioRealizado;
                recompensaRecuperado.Valor = recompensa.Valor;
                recompensaRecuperado.Tipo = recompensa.Tipo;
                recompensaRecuperado.Registro = recompensa.Registro;

                _context.SaveChanges();

                return NoContent();
            }

            return NotFound();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Recompensa recompensa = _context.Recompensas.FirstOrDefault(recompensa => recompensa.Id == id);

            _context.Recompensas.Remove(recompensa);

            _context.SaveChanges();
        }
    }
}
