using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace appfacturacion.Components.Models
{
    public class DetalleFactura
    {
        [Key]
        public int ID_detalle { get; set; }
        public int ID_factura { get; set; }
        public int ID_prod { get; set; }
        public int Cantidad { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Descuento { get; set; }

        [ForeignKey("ID_factura")]
        public Factura Factura { get; set; }

        [ForeignKey("ID_prod")]
        public Producto Producto { get; set; }
    }
}
