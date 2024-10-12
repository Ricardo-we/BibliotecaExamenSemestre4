using System.ComponentModel.DataAnnotations;

namespace Inventario.Models
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        public string Descripcion { get; set; }
        public DateTime FechaPedido { get; set; }
    }
}
