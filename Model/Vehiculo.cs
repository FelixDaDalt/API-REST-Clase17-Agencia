using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_REST_Clase17_Vehiculos_Clientes_Ventas_.Model
{
    public class Vehiculo
    {
        [Key]
        public int VehiculoId { get; set; }

        [Column(TypeName = "varchar(50)")]
        public String? Marca { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string? Modelo { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string? Importe { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha de Baja")]
        public DateTime FechaBaja { get; set; }

    }
}
