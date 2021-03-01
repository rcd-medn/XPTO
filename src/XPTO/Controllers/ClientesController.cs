




using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace XPTO.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] {"Escrito ", "direto ", "no ", "código"};
        }
    }
}
