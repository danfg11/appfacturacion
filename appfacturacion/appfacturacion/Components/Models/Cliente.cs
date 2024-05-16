using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace appfacturacion.Components.Models
{
    public class Cliente
    {
        [Key]
        public int ID_cliente { get; set; }
        public int ID_usu { get; set; }
        public string Nom_cliente { get; set; }
        public string Dir_cliente { get; set; }
        public string Loc_cliente { get; set; }
        public string Prov_cliente { get; set; }
        public string Tel_cliente { get; set; }
        public string Mail_cliente { get; set; }
        public string Info_cliente { get; set; }

        [ForeignKey("ID_usu")]
        public Usuario Usuario { get; set; }
    }
}
