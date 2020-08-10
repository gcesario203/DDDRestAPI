using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DDDApplication.Dtos;
using DDDApplication.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProdutosController : Controller
    {
        private readonly IApplicationServiceProduto applicationService;

        public ProdutosController(IApplicationServiceProduto applicationService)
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
        public ActionResult Post([FromBody] ProdutoDto produtoDto)
        {
            try
            {
                if(produtoDto == null)
                {
                    return NotFound();
                }

                applicationService.Add(produtoDto);

                return Ok("Produto cadastrado com sucesso");
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] ProdutoDto produtoDto)
        {
            try
            {
                if (produtoDto == null)
                {
                    return NotFound();
                }

                applicationService.Update(produtoDto);

                return Ok("Produto alterado com sucesso");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete]
        public ActionResult Deleter([FromBody] ProdutoDto produtoDto)
        {
            try
            {
                if (produtoDto == null)
                {
                    return NotFound();
                }

                applicationService.Remove(produtoDto);

                return Ok("Produto excluído com sucesso");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
