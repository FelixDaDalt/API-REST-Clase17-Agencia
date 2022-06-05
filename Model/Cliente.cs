using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_REST_Clase17_Vehiculos_Clientes_Ventas_.Model
{
    public class Cliente
    {
        [Key]
        public int ClinteId { get; set; }

        [Column(TypeName = "varchar(50)")]
        public String? Nombre { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string? Apellido { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string? Direccion { get; set; }

    }
}
