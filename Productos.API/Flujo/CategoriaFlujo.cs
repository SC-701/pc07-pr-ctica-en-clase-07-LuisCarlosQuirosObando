using Abstracciones.Interfaces.DA;
using Abstracciones.Interfaces.Flujo;
using Abstracciones.Interfaces.Reglas;
using Abstracciones.Modelos;

namespace Flujo
{
    public class CategoriaFlujo : ICategoriaFlujo
    {
        private ICategoriaDA _categoriaDA;

        public CategoriaFlujo(ICategoriaDA categoriaDA)
        {
            _categoriaDA = categoriaDA;
        }
        public async Task<IEnumerable<Categoria>> Obtener()
        {
            return await _categoriaDA.Obtener();
        }
    }
}