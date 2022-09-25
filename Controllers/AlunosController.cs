using Microsoft.AspNetCore.Mvc;
using WebServiceRestfull.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebServiceRestfull.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunosController : ControllerBase
    {
        // GET: api/<AlunosController>
        [HttpGet]
        public IEnumerable<Aluno> Get()
        {
            List<Aluno> alunos = new List<Aluno>
            {
                new Aluno("Luana", 25),
                new Aluno("João", 41)
            };

            alunos.Add(new Aluno("Luana", 25));

            return alunos;
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
