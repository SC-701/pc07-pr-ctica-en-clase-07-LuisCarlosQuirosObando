using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstracciones.Modelos.Servicios.TipoCambio;

namespace Abstracciones.Interfaces.Servicios
{
    public interface ITipoCambioServicio
    {
        Task<decimal> Obtener();
    }
}
