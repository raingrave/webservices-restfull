﻿using Microsoft.AspNetCore.Mvc;
using WebServiceRestfull.Data;
using WebServiceRestfull.Entities;
using WebServiceRestfull.Enums;

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
            AlunoContext alunoContext = new AlunoContext();

            alunos = alunoContext.Aluno.ToList<Aluno>();

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
