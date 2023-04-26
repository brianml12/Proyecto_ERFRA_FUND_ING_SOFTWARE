using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos {
    public class Solicitudes {
        public int IdSolicitud { get; set; }
        public string NombreCliente { get; set; }
        public string NombreProducto { get; set; }
        public string Descripcion { get; set; }
        public int Lote { get; set; }
        public int PrecioUnitario { get; set; }
        public int Importe { get; set; }
        public int Total { get; set; }
        public int IdUsuario { get; set; }
        public string Estado { get; set; }
        public Solicitudes() { }
    }
}
