using Abstracciones.Modelos;

namespace Abstracciones.Interfaces.Flujo
{
    public interface ISubCategoriaFlujo
    {
        Task<IEnumerable<SubCategoria>> Obtener(Guid IdCategoria);
    }
}
