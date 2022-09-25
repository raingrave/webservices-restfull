using Microsoft.AspNetCore.Mvc;
using WebServiceRestfull.Entities;
using WebServiceRestfull.Enums;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebServiceRestfull.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunosController : ControllerBase
    {
        private static List<Aluno> alunos;

        [HttpGet]
        public IActionResult Get()
        {
            alunos = new List<Aluno>
            {
                new Aluno("Luana", 25, 1.7, 110.0, Genero.Feminino),
                new Aluno("Luana", 19, 1.56, 48.5, Genero.Masculino)
            };

            return Ok(alunos);
        }

        // GET api/<AlunosController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {


            return "value";
        }

        // POST api/<AlunosController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AlunosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AlunosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
