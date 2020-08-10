using System;
using System.Collections.Generic;
using DDDApplication.Dtos;
using DDDApplication.Interface;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ClientesController : Controller
    {
        private readonly IApplicationServiceCliente applicationService;

        public ClientesController(IApplicationServiceCliente applicationService)
        {
            this.applicationService = applicationService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(applicationService.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(applicationService.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] ClienteDto clienteDto)
        {
            try 
            {
                if(clienteDto == null)
                {
                    return NotFound();
                }

                applicationService.Add(clienteDto);

                return Ok("Cliente cadastrado com sucesso");
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] ClienteDto clienteDto)
        {
            try
            {
                if(clienteDto == null)
                {
                    return NotFound();
                }

                applicationService.Update(clienteDto);

                return Ok("Alterações realizadas com sucess");

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete]
        public ActionResult Delete([FromBody] ClienteDto clienteDto)
        {
            try
            {
                if(clienteDto == null)
                {
                    return NotFound();
                }

                applicationService.Remove(clienteDto);

                return Ok("Cliente removido com sucesso");
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
