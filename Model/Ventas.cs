using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_REST_Clase17_Vehiculos_Clientes_Ventas_.Model
{
    public class Ventas
    {
        [Key]
        public int VentasId { get; set; }

        [ForeignKey("Vehiculo")]
        public int VehiculoId{ get; set; }
    public Vehiculo? Vehiculo { get; set; }

        [ForeignKey("Cliente")]
        public int ClienteId { get; set; }
        public Cliente? Cliente { get; set; }

        [Column(TypeName = "numeric(18,2)")]
        public decimal Importe { get; set; }

        [Column(TypeName = "numeric(18,2)")]
        public decimal Descuento { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha de Baja")]
        public DateTime Fecha { get; set; }

    }
}
