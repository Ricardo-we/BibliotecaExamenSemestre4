using System.ComponentModel.DataAnnotations;

namespace Inventario.Models
{
    public class Producto
    {
        public int ProductoId { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(100, ErrorMessage = "Nombre no puede tener más de 100 carácteres")]
        public string Nombre { get; set; }
        [Range(0, double.MaxValue, ErrorMessage = "El valor debe ser positivo")]
        public decimal Precio { get; set; }
        [Range(0, double.MaxValue, ErrorMessage = "El valor debe ser mayor que 0.")]
        public decimal Cantidad { get; set; }
    }
}
