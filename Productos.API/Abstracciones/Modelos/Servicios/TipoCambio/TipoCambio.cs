using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracciones.Modelos.Servicios.TipoCambio
{
    public class TipoCambio
    {
        public class BCCRResponse
        {
            public List<Datos> datos { get; set; }
        }

        public class Datos
        {
            public List<Indicador> indicadores { get; set; }
        }

        public class Indicador
        {
            public List<Serie> series { get; set; }
        }

        public class Serie
        {
            public decimal valorDatoPorPeriodo { get; set; }
        }
    }
}
