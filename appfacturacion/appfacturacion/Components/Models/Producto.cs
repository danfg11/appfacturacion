using System.ComponentModel.DataAnnotations;

namespace appfacturacion.Components.Models
{
    public class Producto
    {
        [Key]
        public int ID_prod { get; set; }
        public string Nom_prod { get; set; }
        public string Desc_prod { get; set; }
        public decimal IVA_prod { get; set; }
    }
}
