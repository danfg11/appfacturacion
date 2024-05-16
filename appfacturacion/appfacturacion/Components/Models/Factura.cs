using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace appfacturacion.Components.Models
{
    public class Factura
    {
        [Key]
        public int ID_factura { get; set; }
        public int ID_cliente { get; set; }
        public DateTime FechEmision_factura { get; set; }
        public decimal Monto_total_factura { get; set; }
        public decimal IVA_factura { get; set; }
        public decimal Monto_total_IVA_factura { get; set; }

        [ForeignKey("ID_cliente")]
        public Cliente Cliente { get; set; }
    }
}
