using Abstracciones.Modelos;

namespace Abstracciones.Interfaces.DA
{
    public interface ISubCategoriaDA
    {
        Task<IEnumerable<SubCategoria>> Obtener(Guid IdCategoria);
    }
}
