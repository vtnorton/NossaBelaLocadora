using Microsoft.AspNetCore.Mvc;

namespace Locadora.API.Controllers
{
    [ApiController]
    [Route("locadora")] // Alterado de api/locadora para locadora (caminho de URL mais curta)
    public class LocadoraController : Controller
    {
        [HttpGet]
        public IActionResult Inicio()
        {
            return Ok("Teste");
        }
    }
}
