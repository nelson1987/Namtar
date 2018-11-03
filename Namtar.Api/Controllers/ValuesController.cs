using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Namtar.Api.Contracts;
using Namtar.Application.Interfaces;
using Namtar.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Namtar.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        [ProducesResponseType(200)] //OK
        public IActionResult Get([FromServices] IUsuarioApplicationService service)
        {
            IList<ConsultaUsuario> consulta = Mapper.Map<IList<ConsultaUsuario>>(service.ConsultarUsuario());
            return Ok(consulta);
        }

        // GET api/values/5
        //[HttpGet("{id}")]
        //public IActionResult Get(int id)
        //{
        //    return Ok("value");
        //}

        // POST api/values
        [HttpPost]
        [ProducesResponseType(200)] //OK
        [ProducesResponseType(400)] //Requisição inválida
        [ProducesResponseType(500)] //Erro interno de servidor
        public IActionResult Post([FromBody] CriacaoUsuario modelo,
            [FromServices] IUsuarioApplicationService service)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    service.IncluirUsuario(Mapper.Map<Usuario>(modelo));
                    return Ok("Inserido com sucesso");
                }
                catch (Exception ex)
                {
                    return BadRequest($"Problemas encontrados {ex.Message}");
                }
            }
            return NotFound("Não está valido");
        }

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public IActionResult Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public IActionResult Delete(int id)
        //{
        //}
    }
}
