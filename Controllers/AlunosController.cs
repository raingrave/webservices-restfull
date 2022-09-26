using Microsoft.AspNetCore.Mvc;
using WebServiceRestfull.Data;
using WebServiceRestfull.Entities;
using WebServiceRestfull.Enums;

namespace WebServiceRestfull.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunosController : ControllerBase
    {
        private AlunoContext _context;

        public AlunosController()
        {
            _context = new AlunoContext();
        }

        [HttpGet]
        public IActionResult FindAll()
        {
            return Ok(_context.Alunos);
        }

        [HttpGet("{id}")]
        public IActionResult FindById(int id)
        {
            Aluno aluno = _context.Alunos.FirstOrDefault(aluno => aluno.Id == id);

            if (aluno != null)
            {
                return Ok(aluno);
            }

            return NotFound();
        }

        [HttpPost]
        public IActionResult Create([FromBody] Aluno aluno)
        {
            _context.Alunos.Add(aluno);

            _context.SaveChanges();

            return CreatedAtAction(nameof(FindById), new { Id = aluno.Id }, aluno);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Aluno aluno)
        {
            Aluno alunoRecuperado = _context.Alunos.FirstOrDefault(aluno => aluno.Id == id);

            if (alunoRecuperado != null)
            {
                alunoRecuperado.Nome = aluno.Nome;
                alunoRecuperado.Idade = aluno.Idade;
                alunoRecuperado.Altura = aluno.Altura;
                alunoRecuperado.Peso = aluno.Peso;
                alunoRecuperado.Genero = aluno.Genero;

                _context.SaveChanges();

                return NoContent();
            }

            return NotFound();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Aluno aluno = _context.Alunos.FirstOrDefault(aluno => aluno.Id == id);

            _context.Alunos.Remove(aluno);

            _context.SaveChanges();
        }
    }
}
