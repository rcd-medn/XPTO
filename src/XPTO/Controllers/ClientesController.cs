




using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using XPTO.Data;
using XPTO.DTOs;

namespace XPTO.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientesController : ControllerBase
    {
        private readonly IClienteAPIRepository _repository;
        private readonly IMapper _mapper;

        public ClientesController(IClienteAPIRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ClienteReadDTO>> GetAllClientes()
        {
            var clientes = _repository.GetAllClientes();
            
            return Ok(_mapper.Map<IEnumerable<ClienteReadDTO>>(clientes));
        }
        
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<ClienteReadDTO>> GetClienteById(int id)
        {
            var cliente = _repository.GetClienteById(id);
            
            if (cliente == null) return NotFound();

            return Ok(_mapper.Map<ClienteReadDTO>(cliente));
        }
    }
}
