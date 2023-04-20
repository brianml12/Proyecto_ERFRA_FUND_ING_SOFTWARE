using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos {
    public class Venta {
        public int FolioVenta { get; set; }
        public string Producto { get; set; }
        public string Cliente { get; set; }
        public string Fecha { get; set; }
        public int CantidadVendido { get; set; }
        public double Subtotal { get; set; }
        public double IVA { get; set; }
        public double Total { get; set; }
        public int IdUsuario { get; set; }

        public Venta() { }
    }
}
