using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Abstracciones.Modelos
{
    public class ProductoBase
    {
        [Required(ErrorMessage = "La propiedad nombre es requerida")]
        [StringLength(80, ErrorMessage = "El nombre debe tener ser mayor a 1 y menor a 80 caracteres", MinimumLength = 1)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La propiedad descripción es requerida")]
        [StringLength(200, ErrorMessage = "La descripción debe tener ser mayor a 1 y menor a 200 caracteres", MinimumLength = 1)]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "La propiedad precio es requerida")]
        [Range(0.01, 999999.99, ErrorMessage = "El precio no puede ser menor a 0.01")]
        public decimal Precio { get; set; }

        [Required(ErrorMessage = "La propiedad stock es requerida")]
        [Range(0, int.MaxValue, ErrorMessage = "El stock no puede tener un valor negativo")]
        public int Stock { get; set; }

        [Required(ErrorMessage = "La propiedad código de barras es requerida")]
        [StringLength(9, ErrorMessage = "El código de barras debe tener exactamente 9 caracteres", MinimumLength = 9)]
        [RegularExpression(@"^\d{9}$", ErrorMessage = "El código de barras solo puede tener números")]
        public string CodigoBarras { get; set; }
    }
    public class ProductoRequest : ProductoBase
    {
        public Guid IdSubCategoria { get; set; }
    }

    public class ProductoResponse : ProductoBase
    {
        public Guid Id { get; set; }
        public string SubCategoria { get; set; }
        public string Categoria { get; set; }
    }

    public class ProductoDetalle : ProductoResponse
    {
        [JsonPropertyOrder(12)]
        public decimal PrecioUSD { get; set; }
    }
}
