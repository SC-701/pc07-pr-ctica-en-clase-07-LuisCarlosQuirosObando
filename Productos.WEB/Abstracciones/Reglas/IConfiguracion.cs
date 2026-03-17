using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracciones.Reglas
{
    public interface IConfiguracion
    {
        public string ObtenerMetodo(string seccion, string nombre);
    }
}
