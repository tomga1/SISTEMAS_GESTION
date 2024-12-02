using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Dom_Proveedores
    {
        public int IdProveedor { get; set; }
        public string RazonSocial { get; set; }
        public string Nombre { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string Email { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Observaciones { get; set; }
        public string PaginaWeb { get; set; }

    }
}
