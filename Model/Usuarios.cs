using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_REST_Clase17_Vehiculos_Clientes_Ventas_.Model
{
    public class Usuarios
    {
       [Key]
       public int IdUsuario { get; set; }
       
        [Required(ErrorMessage="El usuario es necesario")]
       public string Usuario { get; set; }
       
        [Required(ErrorMessage = "La clave es necesaria")]
       public string Clave { get; set; }
       
        [Compare("Clave", ErrorMessage ="No coinciden las claves")]
        [NotMapped]
       public string ConfirmacionClave { get; set; }
       
        public string? sal { get; set; } 
    }
}
