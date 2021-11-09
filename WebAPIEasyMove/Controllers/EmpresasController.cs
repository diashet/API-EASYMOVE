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
    public class EmpresasController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var lista = new EmpresasRepository().Listar();
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
                EmpresasRepository repo = new EmpresasRepository();
                Empresas empresas = repo.Consultar(id);
                return Ok(empresas);
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] Empresas empresas)
        {
            try
            {
                EmpresasRepository repo = new EmpresasRepository();
                repo.Inserir(empresas);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPut]
        public IActionResult Put([FromBody] Empresas Empresas)
        {
            try
            {
                EmpresasRepository repo = new EmpresasRepository();
                repo.Alterar(Empresas);
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
                EmpresasRepository repo = new EmpresasRepository();
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
