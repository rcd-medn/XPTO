




using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using XPTO.Data;
using XPTO.Models;

namespace XPTO.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientesController : ControllerBase
    {
        private readonly IClienteAPIRepository _repository;

        public ClientesController(IClienteAPIRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Cliente>> GetAllClientes()
        {
            var clientes = _repository.GetAllClientes();
            
            return Ok(clientes);
        }
        
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<string>> GetClienteById(int id)
        {
            var cliente = _repository.GetClienteById(id);
            if (cliente == null)
            {
                return NotFound();
            }

            return Ok(cliente);
        }
    }
}
