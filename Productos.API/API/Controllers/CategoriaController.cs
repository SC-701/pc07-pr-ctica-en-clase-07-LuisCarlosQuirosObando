using Abstracciones.Interfaces.API;
using Abstracciones.Interfaces.Flujo;
using Abstracciones.Modelos;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase, ICategoriaController
    {
        private ICategoriaFlujo _categoriaFlujo;
        private ILogger<CategoriaController> _logger;

        public CategoriaController(ICategoriaFlujo categoriaFLujo, ILogger<CategoriaController> logger)
        {
            _categoriaFlujo = categoriaFLujo;
            _logger = logger;
        }
        #region Operaciones
        [HttpGet]
        public async Task<IActionResult> Obtener()
        {
            var resultado = await _categoriaFlujo.Obtener();
            if (!resultado.Any())
                return NoContent();
            return Ok(resultado);
        }
        #endregion Operaciones

    }
}
