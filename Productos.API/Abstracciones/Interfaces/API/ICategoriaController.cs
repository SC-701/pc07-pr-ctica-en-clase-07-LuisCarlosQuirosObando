using Abstracciones.Modelos;
using Microsoft.AspNetCore.Mvc;

namespace Abstracciones.Interfaces.API
{
    public interface ICategoriaController
    {
        Task<IActionResult> Obtener();
    }
}
