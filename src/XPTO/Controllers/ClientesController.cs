




using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using XPTO.Data;

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
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] {"Escrito ", "direto ", "no ", "código"};
        }
    }
}
