using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TESTAPI.Services;

namespace TESTAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagoController : ControllerBase
    {
        private readonly PagoService _service;

        public PagoController(PagoService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Procesar([FromQuery] decimal monto)
        {
            var response = _service.ProcesarPago(monto);
            return Ok(response);
        }
    }
}
