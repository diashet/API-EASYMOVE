using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIEasyMove.Models;
using WebAPIEasyMove.Repository;

namespace WebAPIEasyMove.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MudancaController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var lista = new MudancaRepository().Listar();
                return Ok(lista);

            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                MudancaRepository repo = new MudancaRepository();
                Mudanca mudanca = repo.Consultar(id);
                return Ok(mudanca);
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] Mudanca mudanca)
        {
            try
            {
                MudancaRepository repo = new MudancaRepository();
                repo.Inserir(mudanca);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPut]
        public IActionResult Put([FromBody] Mudanca mudanca)
        {
            try
            {
                MudancaRepository repo = new MudancaRepository();
                repo.Alterar(mudanca);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {
                MudancaRepository repo = new MudancaRepository();
                repo.Excluir(id);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
