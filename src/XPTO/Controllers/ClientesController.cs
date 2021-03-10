




using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using XPTO.Data;
using XPTO.DTOs;
using XPTO.Models;

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
        
        [HttpGet("{id}", Name = "GetClienteById")]
        public ActionResult<IEnumerable<ClienteReadDTO>> GetClienteById(int id)
        {
            var cliente = _repository.GetClienteById(id);
            
            if (cliente == null) return NotFound();

            return Ok(_mapper.Map<ClienteReadDTO>(cliente));
        }

        [HttpPost]
        public ActionResult<ClienteReadDTO> CreateCliente(ClienteCreateDTO clienteCreateDTO)
        {
            var clienteModel = _mapper.Map<Cliente>(clienteCreateDTO);
            _repository.CreateCliente(clienteModel);
            _repository.SaveChanges();

            var clienteReadDto = _mapper.Map<ClienteReadDTO>(clienteModel);

            return CreatedAtRoute(nameof(GetClienteById), new { Id = clienteReadDto.ClienteId }, clienteReadDto);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateCliente(int id, ClienteUpdateDTO clienteUpdateDTO)
        {
            var clienteModelFromRepo = _repository.GetClienteById(id);
            if (clienteModelFromRepo == null)
            {
                return NotFound();
            }

            _mapper.Map(clienteUpdateDTO, clienteModelFromRepo);

            _repository.UpdateCliente(clienteModelFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }

        [HttpPatch("{id}")]
        public ActionResult PartialClienteUpdate(int id, JsonPatchDocument<ClienteUpdateDTO> patchDoc)
        {
            var clienteModel = _repository.GetClienteById(id);
            if (clienteModel == null)
            {
                return NotFound();
            }

            var clienteToPatch = _mapper.Map<ClienteUpdateDTO>(clienteModel);
            patchDoc.ApplyTo(clienteToPatch, ModelState);

            if (!TryValidateModel(clienteToPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(clienteToPatch, clienteModel);

            _repository.UpdateCliente(clienteModel);
            _repository.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteCliente(int id)
        {
            var clienteFromRepo = _repository.GetClienteById(id);
            if (clienteFromRepo == null)
            {
                return NotFound();
            }

            _repository.DeleteCliente(clienteFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }
    }
}
