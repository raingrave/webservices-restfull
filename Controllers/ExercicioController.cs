using Microsoft.AspNetCore.Mvc;
using WebServiceRestfull.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebServiceRestfull.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExercicioController : ControllerBase
    {
        // GET: api/<ExercicioController>
        [HttpGet]
        public IActionResult Get()
        {
            List<Exercicio> exercicios = new List<Exercicio>
            {
             new Exercicio("Corrida", "Corrida em ritmo moderado", DateTime.Now),
            };

            return Ok (exercicios); 
        }

        // GET api/<ExercicioController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ExercicioController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ExercicioController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ExercicioController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
