using System.ComponentModel.DataAnnotations;

namespace Inventario.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [MinLength(3, ErrorMessage = "El campo debe tener un mínimo de 3 carácteres")]
        [MaxLength(100, ErrorMessage = "El campo no puede tener más de 100 carácteres")]
        public  string Nombre { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        [EmailAddress(ErrorMessage = "El campo debe ser un correo válido")]
        public string CorreoElectronico { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(8, MinimumLength =8, ErrorMessage = "Debe ser un teléfono válido")]
        public string Telefono { get; set; }
    }
}
