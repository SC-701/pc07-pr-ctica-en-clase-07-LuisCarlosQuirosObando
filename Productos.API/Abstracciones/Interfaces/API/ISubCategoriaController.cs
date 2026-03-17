using Abstracciones.Modelos;
using Microsoft.AspNetCore.Mvc;

namespace Abstracciones.Interfaces.API
{
    public interface ISubCategoriaController
    {
        Task<IActionResult> Obtener(Guid IdCategoria);
    }
}
