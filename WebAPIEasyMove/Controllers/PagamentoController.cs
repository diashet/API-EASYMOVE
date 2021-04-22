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
    public class PagamentoController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var lista = new PagamentoRepository().Listar();
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
                PagamentoRepository repo = new PagamentoRepository();
                Pagamento pagamento = repo.Consultar(id);
                return Ok(pagamento);
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] Pagamento pagamento)
        {
            try
            {
                PagamentoRepository repo = new PagamentoRepository();
                repo.Inserir(pagamento);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPut]
        public IActionResult Put([FromBody] Pagamento pagamento)
        {
            try
            {
                PagamentoRepository repo = new PagamentoRepository();
                repo.Alterar(pagamento);
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
                PagamentoRepository repo = new PagamentoRepository();
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
