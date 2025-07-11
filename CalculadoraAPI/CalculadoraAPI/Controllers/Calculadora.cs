using Microsoft.AspNetCore.Mvc;

namespace CalculadoraAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Calculadora : Controller
    {
        [HttpPost]
        [Route("Soma")]
        public IActionResult Soma([FromBody] decimal numeros1, decimal numero2)
        {
            return Ok();
        }

        [HttpPost]
        [Route("Subtracao")]
        public IActionResult Subtracao([FromBody] decimal numeros1, decimal numero2)
        {
            return Ok();
        }

        [HttpPost]
        [Route("Divisão")]
        public IActionResult Divisão([FromBody] decimal numeros1, decimal numero2)
        {
            return Ok();
        }

        [HttpPost]
        [Route("Multiplicação")]
        public IActionResult Multiplicação([FromBody] decimal numeros1, decimal numero2)
        {
            return Ok();
        }

        [HttpPost]
        [Route("RaizQuadrada")]
        public IActionResult RaizQuadrada([FromBody] decimal numeros1, decimal numero2)
        {
            return Ok();
        }

        [HttpPost]
        [Route("Potenciação")]
        public IActionResult Potenciação([FromBody] decimal numeros1, decimal numero2)
        {
            return Ok();
        }
    }
}
