using Abstracciones.Interfaces.API;
using Abstracciones.Interfaces.Flujo;
using Abstracciones.Modelos;
using Flujo;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubCategoriaController : ControllerBase, ISubCategoriaController
    {
        private ISubCategoriaFlujo _subCategoriaFlujo;
        private ILogger<SubCategoriaController> _logger;

        public SubCategoriaController(ISubCategoriaFlujo subCategoriaFLujo, ILogger<SubCategoriaController> logger)
        {
            _subCategoriaFlujo = subCategoriaFLujo;
            _logger = logger;
        }
        #region Operaciones
        [HttpGet("{IdMarca}")]
        public async Task<IActionResult> Obtener(Guid IdMarca)
        {
            var resultado = await _subCategoriaFlujo.Obtener(IdMarca);
            if (!resultado.Any())
                return NoContent();
            return Ok(resultado);
        }
        #endregion Operaciones

    }
}
