using System.ComponentModel.DataAnnotations;

namespace appfacturacion.Components.Models
{
    public class Usuario
    {
        [Key]
        public int ID_usu { get; set; }
        public string Nom_usu { get; set; }
        public string Ape_usu { get; set; }
        public string Dir_usu { get; set; }
        public string Loc_usu { get; set; }
        public string Prov_usu { get; set; }
        public string Tel_usu { get; set; }
        public string Mail_usu { get; set; }
        public DateTime Fech_usu { get; set; }
        public string Pwd_usu { get; set; }
        public string Rol_usu { get; set; }
    }
}
