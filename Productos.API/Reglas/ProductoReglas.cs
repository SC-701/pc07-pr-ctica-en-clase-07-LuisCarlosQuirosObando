using Abstracciones.Interfaces.Reglas;
using Abstracciones.Interfaces.Servicios;

namespace Reglas
{
    public class ProductoReglas : IProductoReglas
    {
        private readonly ITipoCambioServicio _tipoCambioServicio;
        private readonly IConfiguracion _configuracion;

        public ProductoReglas(ITipoCambioServicio tipoCambioServicio, IConfiguracion configuracion)
        {
            _tipoCambioServicio = tipoCambioServicio;
            _configuracion = configuracion;
        }

        public async Task<decimal> CalcularPrecioUSD(decimal precio)
        {
            var tipoCambio = await _tipoCambioServicio.Obtener();
            return precio / tipoCambio;

        }

    }
}
