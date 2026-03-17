using Abstracciones.Interfaces.API;
using Abstracciones.Interfaces.Flujo;
using Abstracciones.Modelos;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase, IProductoController
    {
        private IProductoFlujo _productoFlujo;
        private ILogger<ProductoController> logger;

        public ProductoController(IProductoFlujo productoFlujo, ILogger<ProductoController> logger)
        {
            _productoFlujo = productoFlujo;
            this.logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> Agregar([FromBody] ProductoRequest producto)
        {
            var resultado = await _productoFlujo.Agregar(producto);
            return CreatedAtAction(nameof(Obtener), new {Id=resultado},null);
        }

        [HttpPut("{Id}")]
        public async Task<IActionResult> Editar([FromRoute] Guid Id, ProductoRequest producto)
        {
            if (!await VerificarProductoExiste(Id))
                return NotFound("El producto no existe");
            var resultado = await _productoFlujo.Editar(Id, producto);
            return Ok(resultado);
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Eliminar([FromRoute] Guid Id)
        {
            if (!await VerificarProductoExiste(Id))
                return NotFound("El producto no existe");
            var resultado = await _productoFlujo.Eliminar(Id);
            return NoContent();
        }
        [HttpGet("ObtenerTodos")]
        public async Task<IActionResult> Obtener()
        {
            var resultado = await _productoFlujo.Obtener();
            if (!resultado.Any())
                return NoContent();
            return Ok(resultado);
        }
        [HttpGet("ObtenerPorId/{Id}")]
        public async Task<IActionResult> Obtener([FromRoute] Guid Id)
        {
            var resultado = await _productoFlujo.Obtener(Id);
            return Ok(resultado);
        }
        #region Helpers
        private async Task<bool> VerificarProductoExiste(Guid Id)
        {
            var resultadoValidacion = false;
            var resultadoProductoExiste = await _productoFlujo.Obtener(Id);
            if (resultadoProductoExiste != null)
                resultadoValidacion = true;
            return resultadoValidacion;
        }
        #endregion
    }
}
