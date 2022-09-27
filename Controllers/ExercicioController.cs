using Microsoft.AspNetCore.Mvc;
using WebServiceRestfull.Data;
using WebServiceRestfull.Entities;
using WebServiceRestfull.Enums;

namespace WebServiceRestfull.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExercicioController : ControllerBase
    {
        private ExercicioContext _context;

        public ExercicioController()
        {
            _context = new ExercicioContext();
        }

        [HttpGet]
        public IActionResult FindAll()
        {
            return Ok(_context.Exercicios);
        }

        [HttpGet("{id}")]
        public IActionResult FindById(int id)
        {
            Exercicio exercicio = _context.Exercicios.FirstOrDefault(exercicio => exercicio.Id == id);

            if (exercicio != null)
            {
                return Ok(exercicio);
            }

            return NotFound();
        }

        [HttpPost]
        public IActionResult Create([FromBody] Exercicio exercicio)
        {
            exercicio.Registro = DateTime.Now;

            _context.Exercicios.Add(exercicio);

            _context.SaveChanges();

            return CreatedAtAction(nameof(FindById), new { Id = exercicio.Id }, exercicio);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Exercicio exercicio)
        {
            Exercicio exercicioRecuperado = _context.Exercicios.FirstOrDefault(exercicio => exercicio.Id == id);

            if (exercicioRecuperado != null)
            {
                exercicioRecuperado.Nome = exercicio.Nome;
                exercicioRecuperado.Descricao = exercicio.Descricao;
                exercicioRecuperado.Registro = exercicio.Registro;

                _context.SaveChanges();

                return NoContent();
            }

            return NotFound();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Exercicio exercicio = _context.Exercicios.FirstOrDefault(exercicio => exercicio.Id == id);

            _context.Exercicios.Remove(exercicio);

            _context.SaveChanges();
        }
    }
}
